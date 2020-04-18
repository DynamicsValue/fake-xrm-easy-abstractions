using System;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Plugins
{
    public interface IXrmFakedPluginContextProperties
    {
        ITracingService TracingService { get; }
        

        IServiceEndpointNotificationService ServiceEndpointNotificationService { get; }

        IOrganizationServiceFactory OrganizationServiceFactory { get; }

        IEntityDataSourceRetrieverService EntityDataSourceRetrieverService { get; }

        IServiceProvider GetServiceProvider(IPluginExecutionContext plugCtx);

    }
}
