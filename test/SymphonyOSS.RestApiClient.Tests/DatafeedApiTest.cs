// Licensed to the Symphony Software Foundation (SSF) under one
// or more contributor license agreements.  See the NOTICE file
// distributed with this work for additional information
// regarding copyright ownership.  The SSF licenses this file
// to you under the Apache License, Version 2.0 (the
// "License"); you may not use this file except in compliance
// with the License.  You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing,
// software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, either express or implied.  See the License for the
// specific language governing permissions and limitations
// under the License.

using System.Collections;
using System.Collections.Generic;
using System.Net.Http;

namespace SymphonyOSS.RestApiClient.Tests
{
    using System;
    using System.Threading;
    using System.Threading.Tasks;
    using Api;
    using Api.AgentApi;
    using Authentication;
    using Generated.OpenApi.AgentApi;
    using Moq;
    using Xunit;
    using System.Linq;

    public class DatafeedApiTest
    {

        private readonly DatafeedApi _datafeedApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public DatafeedApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _datafeedApi = new DatafeedApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureHandler_receives_messages()
        {
            var semaphore = new Semaphore(0, int.MaxValue);
            var messageList = CreateMessageList(2);
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<Datafeed>>>(), "sessionToken", "keyManagerToken", default(CancellationToken))).Returns(new Datafeed() {Id = "streamId"});
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, string, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>(), "streamId", "sessionToken", "keyManagerToken", (int?)null, default(CancellationToken)))
                .Returns(messageList);
            var messagesReceived = 0;
            _datafeedApi.OnMessage += (_, messageEventArgs) =>
            {
                ++messagesReceived;
                if (messageEventArgs.Message.Id == "msg2")
                {
                    semaphore.Release(1);
                }
            };
            var task = Task.Run(() => _datafeedApi.Listen());
            if (!semaphore.WaitOne(1000))
            {
                Assert.True(false);
            }
            _datafeedApi.Stop();
            if (!task.Wait(1000))
            {
                Assert.True(false);
            }
            Assert.True(messagesReceived >= 2);
        }


        [Fact]
        public void EnsureRemoved_handler_does_not_receive_messages()
        {
            var sendSemaphore = new Semaphore(1, int.MaxValue);
            var mainSemaphore = new Semaphore(0, int.MaxValue);
            var messagesSent = 0;
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<Datafeed>>>(), "sessionToken", "keyManagerToken", default(CancellationToken))).Returns(new Datafeed {Id = "streamId"});
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, string, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>(), "streamId", "sessionToken", "keyManagerToken", (int?)null, default(CancellationToken)))
                .Returns(() =>
                {
                    if (messagesSent <= 1)
                    {
                        sendSemaphore.WaitOne();
                    }
                    if (messagesSent < 10)
                    {
                        var messageList = CreateMessageList(1, messagesSent);
                        messagesSent += messageList.Count();
                        return messageList;
                    }
                    else
                    {
                        mainSemaphore.Release();
                        return null;
                    }
                });
            var messagesReceived = 0;
            EventHandler<MessageEventArgs> handler = null;
            handler = (_, messageEventArgs) =>
            {
                ++messagesReceived;
                _datafeedApi.OnMessage -= handler;
                sendSemaphore.Release(1);
            };
            _datafeedApi.OnMessage += handler;
            var task = Task.Run(() => _datafeedApi.Listen());
            if (!mainSemaphore.WaitOne(1000))
            {
                Assert.True(false);
            }
            _datafeedApi.Stop();
            if (!task.Wait(1000))
            {
                Assert.True(false);
            }
            Assert.Equal(10, messagesSent);
            Assert.Equal(1, messagesReceived);
        }

        [Fact]
        public void EnsureListen_can_be_stopped()
        {
            var semaphore = new Semaphore(0, int.MaxValue);
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<Datafeed>>>(), "sessionToken", "keyManagerToken", default(CancellationToken))).Returns(new Datafeed(){Id = "streamId"});
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, string, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>(), "streamId", "sessionToken", "keyManagerToken", (int?)null, default(CancellationToken)))
                .Returns((System.Collections.ObjectModel.ObservableCollection<V4Event>) null)
                .Callback(() =>
                {
                    semaphore.Release(1);
                });
            var task = Task.Run(() => _datafeedApi.Listen());
            semaphore.WaitOne();
            _datafeedApi.Stop();
            task.Wait();
            _apiExecutorMock.Verify(obj => obj.Execute(It.IsAny<Func<string, string, string, int?, CancellationToken, Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>(), "streamId", "sessionToken", "keyManagerToken", (int?)null, default(CancellationToken)));
        }

        private System.Collections.ObjectModel.ObservableCollection<V4Event> CreateMessageList(int count, int startId = 1)
        {
            var result = new System.Collections.ObjectModel.ObservableCollection<V4Event>();
            for (var i = 0; i < count; ++i)
            {
                var msg = new V4Message()
                {
                    MessageId = "msg" + (startId + i),
                    Timestamp = 1477297302,
                    Stream = new V4Stream() { StreamId = "streamId"},
                    User = new V4User() { UserId = 1}
                };

                var evt = new V4Event()
                {
                    Type = V4EventType.MESSAGESENT,
                    Payload = new V4Payload() {MessageSent = new V4MessageSent() {Message = msg}}
                };
                result.Add(evt);
            };
            return result;
        }
    }
}
