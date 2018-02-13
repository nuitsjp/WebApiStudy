﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace HelloWebApi
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for HelloWebApiClient.
    /// </summary>
    public static partial class HelloWebApiClientExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Employee> GetEmployees(this IHelloWebApiClient operations)
            {
                return Task.Factory.StartNew(s => ((IHelloWebApiClient)s).GetEmployeesAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Employee>> GetEmployeesAsync(this IHelloWebApiClient operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetEmployeesWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
