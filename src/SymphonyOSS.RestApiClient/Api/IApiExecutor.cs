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
    using System.Threading.Tasks;
    using System.Threading;
    /// <summary>
    /// Execution strategy for API calls to allow for custom retry
    /// strategies.
    /// </summary>
    public interface IApiExecutor
    {

        Task<TResult> ExecuteAsync<TResult>(Func<Task<TResult>> action);

        TResult Execute<T1, TResult>(Func<T1, CancellationToken, Task<TResult>> func, T1 arg1, CancellationToken token = default(CancellationToken));

        TResult Execute<T1, T2, TResult>(Func<T1, T2, CancellationToken, Task<TResult>> func, T1 arg1, T2 arg2, CancellationToken token = default(CancellationToken));

        TResult Execute<T1, T2, T3, TResult>(Func<T1, T2, T3, CancellationToken, Task<TResult>> func, T1 arg1, T2 arg2, T3 arg3, CancellationToken token = default(CancellationToken));

        TResult Execute<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, CancellationToken, Task<TResult>> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, CancellationToken token = default(CancellationToken));

        TResult Execute<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, CancellationToken, Task<TResult>> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, CancellationToken token = default(CancellationToken));

        TResult Execute<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, CancellationToken, Task<TResult>> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, CancellationToken token = default(CancellationToken));

        TResult Execute<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, CancellationToken, Task<TResult>> func, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, CancellationToken token = default(CancellationToken));

    }
}
