using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
    public interface ICallerProperties
    {
        EntityReference CallerId { get; set; }
        EntityReference BusinessUnitId { get; set; }
    }
}
