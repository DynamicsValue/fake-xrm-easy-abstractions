using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
    /// <summary>
    /// Fake Tracing Service Interface
    /// </summary>
    public interface IXrmFakedTracingService: ITracingService
    {
        /// <summary>
        /// returns all collected trace as a string
        /// </summary>
        /// <returns></returns>
        string DumpTrace();
    }
}