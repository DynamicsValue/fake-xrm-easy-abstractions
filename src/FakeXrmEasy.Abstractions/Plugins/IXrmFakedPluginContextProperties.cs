using System;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Plugins
{
    public interface IXrmFakedPluginContextProperties
    {
        ITracingService TracingService { get; set; }
        IServiceProvider ServiceProvider { get; set; }
    }
}
