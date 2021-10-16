using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
    public interface IXrmFakedTracingService: ITracingService
    {
        string DumpTrace();
    }
}