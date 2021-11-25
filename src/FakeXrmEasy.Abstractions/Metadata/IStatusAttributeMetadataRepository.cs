using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace FakeXrmEasy.Abstractions.Metadata
{
    /// <summary>
    /// Status Attribute Metadata Repository
    /// </summary>
    public interface IStatusAttributeMetadataRepository
    {
        /// <summary>
        /// Get By Global OptionSet Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        StatusAttributeMetadata GetByGlobalOptionSetName(string name);

        /// <summary>
        /// Get By Entity and Attribute Name
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        StatusAttributeMetadata GetByAttributeName(string entityName, string attributeName);
        
        /// <summary>
        /// Set By Global OptionSet Name
        /// </summary>
        /// <param name="globalOptionSetName"></param>
        /// <param name="metadata"></param>
        void Set(string globalOptionSetName, StatusAttributeMetadata metadata);

        /// <summary>
        /// Set By Entity and Attribute Name
        /// </summary>
        /// <param name="entityName"></param>
        /// <param name="attributeName"></param>
        /// <param name="metadata"></param>
        void Set(string entityName, string attributeName, StatusAttributeMetadata metadata);

        /// <summary>
        /// Create a Query for the Status Attribute Metadata
        /// </summary>
        /// <returns></returns>
        IQueryable<StatusAttributeMetadata> CreateQuery();
    }
    
}