
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Plugins
{
    public interface IXrmFakedTracingService: ITracingService
    {
        string DumpTrace();
    }
}