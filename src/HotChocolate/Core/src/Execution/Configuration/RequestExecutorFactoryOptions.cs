using System;
using System.Collections.Generic;
using HotChocolate.Execution.Options;

namespace HotChocolate.Execution.Configuration
{
    public class RequestExecutorFactoryOptions
    {
        public SchemaBuilder? SchemaBuilder { get; set; }

        public RequestExecutorOptions? RequestExecutorOptions { get; set; }

        public IList<SchemaBuilderAction> SchemaBuilderActions { get; } =
            new List<SchemaBuilderAction>();

        public IList<RequestExecutorOptionsAction> RequestExecutorOptionsActions { get; } =
            new List<RequestExecutorOptionsAction>();

        public IList<RequestServicesMiddleware> Pipeline { get; } =
            new List<RequestServicesMiddleware>();

        public IList<CreateErrorFilter> ErrorFilters { get; } =
            new List<CreateErrorFilter>();
    }
}