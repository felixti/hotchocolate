using System;
using HotChocolate.Execution.Options;

namespace HotChocolate.Execution
{
    /// <summary>
    /// Defines request middleware that can be added to the GraphQL request pipeline.
    /// </summary>
    public delegate RequestDelegate RequestServicesMiddleware(
        IServiceProvider services, 
        IRequestExecutorOptionsAccessor options, 
        RequestDelegate next);
}