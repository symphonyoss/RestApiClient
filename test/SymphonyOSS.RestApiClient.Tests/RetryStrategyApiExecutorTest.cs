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

namespace SymphonyOSS.RestApiClient.Tests
{
    using Api;
    using Generated.OpenApi.AgentApi.Client;
    using Moq;
    using System;
    using Xunit;

    public class RetryStrategyApiExecutorTest
    {

        private readonly Mock<IRetryStrategy> _retryStrategyMock;

        private readonly RetryStrategyApiExecutor _retryStrategyApiExecutor;

        private int _countFunctionCalls;

        private int[] _functionParameters;

        public RetryStrategyApiExecutorTest()
        {
            _retryStrategyMock = new Mock<IRetryStrategy>();
            _retryStrategyApiExecutor = new RetryStrategyApiExecutor(_retryStrategyMock.Object);
        }

        [Fact]
        public void EnsureCounts_retries_starting_with_zero()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 2)).Returns(false);
            var func = CreateOneParameterFunc(2, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0), Times.Once());
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1), Times.Once());
        }

        [Fact]
        public void EnsureRetries_one_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateOneParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void EnsureRetries_two_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateTwoParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1, 2);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(2, _functionParameters[1]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void EnsureRetries_three_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateThreeParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1, 2, 3);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(2, _functionParameters[1]);
            Assert.Equal(3, _functionParameters[2]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void EnsureRetries_four_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateFourParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1, 2, 3, 4);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(2, _functionParameters[1]);
            Assert.Equal(3, _functionParameters[2]);
            Assert.Equal(4, _functionParameters[3]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void EnsureRetries_five_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateFiveParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1, 2, 3, 4, 5);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(2, _functionParameters[1]);
            Assert.Equal(3, _functionParameters[2]);
            Assert.Equal(4, _functionParameters[3]);
            Assert.Equal(5, _functionParameters[4]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void EnsureRetries_six_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateSixParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1, 2, 3, 4, 5, 6);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(2, _functionParameters[1]);
            Assert.Equal(3, _functionParameters[2]);
            Assert.Equal(4, _functionParameters[3]);
            Assert.Equal(5, _functionParameters[4]);
            Assert.Equal(6, _functionParameters[5]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        [Fact]
        public void EnsureRetries_seven_parameter_function_once_and_then_returns_value()
        {
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 0)).Returns(true);
            _retryStrategyMock.Setup(obj => obj.ShouldRetry(It.IsAny<ApiException>(), 1)).Returns(false);
            var func = CreateSevenParameterFunc(1, 401, 100);
            var result = _retryStrategyApiExecutor.Execute(func, 1, 2, 3, 4, 5, 6, 7);
            Assert.Equal(1, _functionParameters[0]);
            Assert.Equal(2, _functionParameters[1]);
            Assert.Equal(3, _functionParameters[2]);
            Assert.Equal(4, _functionParameters[3]);
            Assert.Equal(5, _functionParameters[4]);
            Assert.Equal(6, _functionParameters[5]);
            Assert.Equal(7, _functionParameters[6]);
            Assert.Equal(100, result);
            _retryStrategyMock.Verify(obj => obj.ShouldRetry(It.IsAny<ApiException>(), It.IsAny<int>()), Times.Once());
        }

        private Func<int, int> CreateOneParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return arg1 =>
            {
                _functionParameters = new int[] {arg1};
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

        private Func<int, int, int> CreateTwoParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return (arg1, arg2) =>
            {
                _functionParameters = new int[] { arg1, arg2 };
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

        private Func<int, int, int, int> CreateThreeParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return (arg1, arg2, arg3) =>
            {
                _functionParameters = new int[] { arg1, arg2, arg3 };
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

        private Func<int, int, int, int, int> CreateFourParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return (arg1, arg2, arg3, arg4) =>
            {
                _functionParameters = new int[] { arg1, arg2, arg3, arg4 };
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

        private Func<int, int, int, int, int, int> CreateFiveParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return (arg1, arg2, arg3, arg4, arg5) =>
            {
                _functionParameters = new int[] { arg1, arg2, arg3, arg4, arg5 };
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

        private Func<int, int, int, int, int, int, int> CreateSixParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6) =>
            {
                _functionParameters = new int[] { arg1, arg2, arg3, arg4, arg5, arg6 };
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

        private Func<int, int, int, int, int, int, int, int> CreateSevenParameterFunc(int exceptionsThrown, int statusCode, int result)
        {
            return (arg1, arg2, arg3, arg4, arg5, arg6, arg7) =>
            {
                _functionParameters = new int[] { arg1, arg2, arg3, arg4, arg5, arg6, arg7 };
                ++_countFunctionCalls;
                if (_countFunctionCalls <= exceptionsThrown)
                {
                    throw new ApiException(statusCode, "");
                }
                return result;
            };
        }

    }

}
