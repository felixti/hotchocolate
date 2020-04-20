using System;
using System.Collections.Generic;
using System.Threading;
using HotChocolate.Execution.Utilities;
using HotChocolate.Utilities;

namespace HotChocolate.Execution
{
    internal interface IOperationContext
    {
        /// <summary>
        /// Gets the schema on which the query is being executed.
        /// </summary>
        ISchema Schema { get; }

        /// <summary>
        /// Gets the request scope services
        /// </summary>
        IServiceProvider Services { get; }

        /// <summary>
        /// Gets the error handler which adds additional context
        /// data to errors and exceptions.
        /// </summary>
        IErrorHandler ErrorHandler { get; }

        /// <summary>
        /// Gets the operation that is being executed.
        /// </summary>
        /// <value></value>
        IOperation Operation { get; }

        /// <summary>
        /// Gets the coerced variables.
        /// </summary>
        /// <value></value>
        IVariableValueCollection Variables { get; }

        /// <summary>
        /// Gets the query result.
        /// </summary>
        /// <value></value>
        IQueryResultBuilder Result { get; }

        /// <summary>
        /// The context data dictionary can be used by middlewares and
        /// resolvers to store and retrieve data during execution.
        /// </summary>
        IDictionary<string, object> ContextData { get; }

        /// <summary>
        /// Gets a cancellation token is used to signal
        /// if the request has be aborted.
        /// </summary>
        CancellationToken RequestAborted { get; }

        /*
        IReadOnlyList<FieldSelection> CollectFields(
            ObjectType objectType,
            SelectionSetNode selectionSet,
            Path path);
            */

        /// <summary>
        /// Gets the activator helper class.
        /// </summary>
        IActivator Activator { get; }

        /// <summary>
        /// Gets the diagnostics writer for query execution.
        /// </summary>
        // QueryExecutionDiagnostics Diagnostics { get; }

        /// <summary>
        /// Gets the type conversion service.
        /// </summary>
        /// <value></value>
        ITypeConversion Converter { get; }

        /// <summary>
        /// Adds an error thread-safe to the result object.
        /// </summary>
        /// <param name="error">The error that shall be added.</param>
        void AddError(IError error);
    }
}
