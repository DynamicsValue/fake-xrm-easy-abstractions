using System;

namespace FakeXrmEasy.Abstractions
{
    public interface ICallerProperties
    {
        Guid CallerId { get; set; }
        Guid BusinessUnitId { get; set; }
    }
}
