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

#if FAKE_XRM_EASY_9
        IEntityDataSourceRetrieverService EntityDataSourceRetrieverService { get; }

        Entity EntityDataSourceRetriever { get; set; }
#endif

        IServiceProvider GetServiceProvider(XrmFakedPluginExecutionContext plugCtx);

    }
}
