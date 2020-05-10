using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace FakeXrmEasy.Abstractions.Metadata
{
    public interface IStatusAttributeMetadataRepository
    {
        StatusAttributeMetadata GetByGlobalOptionSetName(string name);

        StatusAttributeMetadata GetByAttributeName(string entityName, string attributeName);
        void Set(string globalOptionSetName, StatusAttributeMetadata metadata);

        void Set(string entityName, string attributeName, StatusAttributeMetadata metadata);

        IQueryable<StatusAttributeMetadata> CreateQuery();
    }
    
}