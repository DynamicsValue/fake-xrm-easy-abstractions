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
        
        /// <summary>
        /// Id of the SYSTEM account (i.e. https://learn.microsoft.com/en-us/dotnet/api/microsoft.xrm.sdk.iorganizationservicefactory.createorganizationservice?view=dataverse-sdk-latest)
        /// </summary>
        EntityReference SystemUserId { get; set; }
    }
}

