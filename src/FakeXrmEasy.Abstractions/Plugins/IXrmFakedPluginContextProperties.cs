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

        IServiceProvider GetServiceProvider(XrmFakedPluginExecutionContext plugCtx);

    }
}
