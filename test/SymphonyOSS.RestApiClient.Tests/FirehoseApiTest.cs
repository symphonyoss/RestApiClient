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
    using System.Collections.Generic;
    using System.Linq;

    public class FirehoseApiTest
    {
        private readonly FirehoseApi _firehoseApi;

        private readonly Mock<IApiExecutor> _apiExecutorMock;

        public FirehoseApiTest()
        {
            var sessionManagerMock = new Mock<IAuthTokens>();
            sessionManagerMock.Setup(obj => obj.SessionToken).Returns("sessionToken");
            sessionManagerMock.Setup(obj => obj.KeyManagerToken).Returns("keyManagerToken");
            _apiExecutorMock = new Mock<IApiExecutor>();
            _firehoseApi = new FirehoseApi(sessionManagerMock.Object, "", new HttpClient(), _apiExecutorMock.Object);
        }

        [Fact]
        public void EnsureHandler_receives_messages()
        {
            var semaphore = new Semaphore(0, int.MaxValue);
            var messageList = CreateMessageList(2);
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<Firehose>>>(), "sessionToken", "keyManagerToken", default(CancellationToken))).Returns(new Firehose() {Id = "streamId"});
            _apiExecutorMock.Setup(obj => obj.ExecuteAsync(It.IsAny<Func<Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>()))
            .ReturnsAsync(messageList);
            var messagesReceived = 0;
            _firehoseApi.OnMessage += (_, messageEventArgs) =>
            {
                ++messagesReceived;
                if (messageEventArgs.Message.Id == "msg2")
                {
                    semaphore.Release(1);
                }
            };
            var task = Task.Run(() => _firehoseApi.Listen());
            if (!semaphore.WaitOne(1000))
            {
                Assert.True(false);
            }
            _firehoseApi.Stop();
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
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<Firehose>>>(), "sessionToken", "keyManagerToken", default(CancellationToken))).Returns(new Firehose() { Id = "streamId"});
            _apiExecutorMock.Setup(obj => obj.ExecuteAsync(It.IsAny<Func<Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>()))
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
                        return Task.FromResult(messageList);
                    }
                    else
                    {
                        mainSemaphore.Release();
                        return Task.FromResult< System.Collections.ObjectModel.ObservableCollection<V4Event>>(null);
                    }
                });
            var messagesReceived = 0;
            EventHandler<MessageEventArgs> handler = null;
            handler = (_, messageEventArgs) =>
            {
                ++messagesReceived;
                _firehoseApi.OnMessage -= handler;
                sendSemaphore.Release(1);
            };
            _firehoseApi.OnMessage += handler;
            var task = Task.Run(() => _firehoseApi.Listen());
            if (!mainSemaphore.WaitOne(1000))
            {
                Assert.True(false);
            }
            _firehoseApi.Stop();
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
            _apiExecutorMock.Setup(obj => obj.Execute(It.IsAny<Func<string, string, CancellationToken, Task<Firehose>>>(), "sessionToken", "keyManagerToken", default(CancellationToken))).Returns(new Firehose() {Id = "streamId"});
            _apiExecutorMock.Setup(obj => obj.ExecuteAsync(It.IsAny<Func<Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>()))
                .ReturnsAsync((System.Collections.ObjectModel.ObservableCollection<V4Event>)null)
                .Callback(() =>
                {
                    semaphore.Release(1);
                });
            var task = Task.Run(() => _firehoseApi.Listen());
            semaphore.WaitOne();
            _firehoseApi.Stop();
            task.Wait();
            _apiExecutorMock.Verify(obj => obj.ExecuteAsync(It.IsAny<Func<Task<System.Collections.ObjectModel.ObservableCollection<V4Event>>>>()));
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
                    Stream = new V4Stream() { StreamId = "streamId" },
                    User = new V4User() { UserId = 1 }
                };

                var evt = new V4Event()
                {
                    Type = V4EventType.MESSAGESENT,
                    Payload = new V4Payload() { MessageSent = new V4MessageSent() { Message = msg } }
                };
                result.Add(evt);
            };
            return result;
        }
    }
}
