using System;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Plugins
{
    /// <summary>
    /// Faked Plugin Context Properties
    /// </summary>
    public interface IXrmFakedPluginContextProperties
    {
        /// <summary>
        /// Organization Service
        /// </summary>
        IOrganizationService OrganizationService { get; }

        /// <summary>
        /// Tracing Service
        /// </summary>
        IXrmFakedTracingService TracingService { get; }

        /// <summary>
        /// Service Endpoint Notification Service
        /// </summary>
        IServiceEndpointNotificationService ServiceEndpointNotificationService { get; }

        /// <summary>
        /// Organization Service Factory
        /// </summary>
        IOrganizationServiceFactory OrganizationServiceFactory { get; }

#if FAKE_XRM_EASY_9
        /// <summary>
        /// Entity DataSource Retriever Service
        /// </summary>
        IEntityDataSourceRetrieverService EntityDataSourceRetrieverService { get; }

        /// <summary>
        /// Entity DataSource Retriever
        /// </summary>
        Entity EntityDataSourceRetriever { get; set; }
#endif

        /// <summary>
        /// Get the Service Provider for the specified <see cref="IPluginExecutionContext"/>
        /// </summary>
        /// <param name="plugCtx"></param>
        /// <returns></returns>
        IServiceProvider GetServiceProvider(XrmFakedPluginExecutionContext plugCtx);
    }
}

