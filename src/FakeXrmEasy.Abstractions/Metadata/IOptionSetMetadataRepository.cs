using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace FakeXrmEasy.Abstractions.Metadata
{
    public interface IOptionSetMetadataRepository
    {
        OptionSetMetadata GetByName(string sGlobalOptionSetName);
        void Set(string sGlobalOptionSetName, OptionSetMetadata metadata);

        IQueryable<OptionSetMetadata> CreateQuery();
    }
    
}