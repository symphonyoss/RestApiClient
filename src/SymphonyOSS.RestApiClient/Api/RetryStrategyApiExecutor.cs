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

namespace SymphonyOSS.RestApiClient.Api
{
    using System;

    /// <summary>
    /// <para>
    /// Defines a strategy for retrying when encountering an exception caused
    /// by an authentication error. When a request fails with a 401 authentication
    /// exception, both authentication tokens will be regenerated and the request
    /// will be attempted once more. If the second attempt fails, the authentication
    /// exception will be re-thrown.
    /// </para>
    /// <para>
    /// The strategy will not retry when encountering any other exceptions, instead
    /// the exception will be re-thrown to the caller.
    /// </para>
    /// </summary>
    public class RetryStrategyApiExecutor : IApiExecutor
    {
        private readonly IRetryStrategy _retryStrategy;

        /// <summary>
        /// Initializes a new instance of the <see cref="RetryStrategyApiExecutor"/> class.
        /// Uses a retry strategy to determine when to retry an unsuccessful request.
        /// </summary>
        /// <param name="retryStrategy">The retry strategy used.</param>
        public RetryStrategyApiExecutor(IRetryStrategy retryStrategy)
        {
            _retryStrategy = retryStrategy;
        }

        public TResult Execute<T1, TResult>(Func<T1, TResult> func, T1 arg1)
        {
            Func<TResult> tryFunc = () => func(arg1);
            return Try(tryFunc, 0);
        }

        public TResult Execute<T1, T2, TResult>(Func<T1, T2, TResult> func, T1 arg1, T2 arg2)
        {
            Func<TResult> tryFunc = () => func(arg1, arg2);
            return Try(tryFunc, 0);
        }

        public TResult Execute<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> func, T1 arg1, T2 arg2, T3 arg3)
        {
            Func<TResult> tryFunc = () => func(arg1, arg2, arg3);
            return Try(tryFunc, 0);
        }

        public TResult Execute<T1, T2, T3, T4, TResult>(
            Func<T1, T2, T3, T4, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            Func<TResult> tryFunc = () => func(arg1, arg2, arg3, arg4);
            return Try(tryFunc, 0);
        }

        public TResult Execute<T1, T2, T3, T4, T5, TResult>(
            Func<T1, T2, T3, T4, T5, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            Func<TResult> tryFunc = () => func(arg1, arg2, arg3, arg4, arg5);
            return Try(tryFunc, 0);
        }

        public TResult Execute<T1, T2, T3, T4, T5, T6, TResult>(
            Func<T1, T2, T3, T4, T5, T6, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            Func<TResult> tryFunc = () => func(arg1, arg2, arg3, arg4, arg5, arg6);
            return Try(tryFunc, 0);
        }

        public TResult Execute<T1, T2, T3, T4, T5, T6, T7, TResult>(
            Func<T1, T2, T3, T4, T5, T6, T7, TResult> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            Func<TResult> tryFunc = () => func(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            return Try(tryFunc, 0);
        }

        private TResult Try<TResult>(Func<TResult> func, int retries)
        {
            try
            {
                return func();
            }
            catch (Exception e)
            {
                return HandleException(e, func, retries);
            }
        }

        private TResult HandleException<TResult>(Exception e, Func<TResult> func, int retries)
        {
            if (_retryStrategy.ShouldRetry(e, retries))
            {
                return Try(func, retries + 1);
            }

            throw e;
        }
    }
}
