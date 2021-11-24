using System.Linq;
using Microsoft.Xrm.Sdk.Metadata;

namespace FakeXrmEasy.Abstractions.Metadata
{
    /// <summary>
    /// OptionSet Metadata Repository
    /// </summary>
    public interface IOptionSetMetadataRepository
    {
        /// <summary>
        /// Return the OptionSet Metadata for the specified OptionSet
        /// </summary>
        /// <param name="sGlobalOptionSetName"></param>
        /// <returns></returns>
        OptionSetMetadata GetByName(string sGlobalOptionSetName);
        
        /// <summary>
        /// Set the specified OptionSet Metadata
        /// </summary>
        /// <param name="sGlobalOptionSetName"></param>
        /// <param name="metadata"></param>
        void Set(string sGlobalOptionSetName, OptionSetMetadata metadata);

        /// <summary>
        /// Create a Query for the OptionSet Metadata
        /// </summary>
        /// <returns></returns>
        IQueryable<OptionSetMetadata> CreateQuery();
    }
    
}