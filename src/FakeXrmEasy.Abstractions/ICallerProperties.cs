using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
    /// <summary>
    /// The default user and business unit used to impersonate service calls
    /// </summary>
    public interface ICallerProperties
    {
        /// <summary>
        /// Default User
        /// </summary>
        EntityReference CallerId { get; set; }
        /// <summary>
        /// Default BusinessUnit
        /// </summary>
        EntityReference BusinessUnitId { get; set; }
    }
}
