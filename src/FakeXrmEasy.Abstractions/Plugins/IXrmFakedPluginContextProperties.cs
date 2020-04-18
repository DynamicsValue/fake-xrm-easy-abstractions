using System;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Plugins
{
    public interface IXrmFakedPluginContextProperties
    {
        IOrganizationService OrganizationService { get; }
        IXrmFakedTracingService TracingService { get; }
        
        IServiceEndpointNotificationService ServiceEndpointNotificationService { get; }

        IOrganizationServiceFactory OrganizationServiceFactory { get; }

        IEntityDataSourceRetrieverService EntityDataSourceRetrieverService { get; }

        Entity EntityDataSourceRetriever { get; set; }
        
        IServiceProvider GetServiceProvider(XrmFakedPluginExecutionContext plugCtx);

    }
}
