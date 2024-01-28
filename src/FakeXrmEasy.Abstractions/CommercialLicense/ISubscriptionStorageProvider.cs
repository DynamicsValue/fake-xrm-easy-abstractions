using System.Threading.Tasks;

namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Provides an abstraction to store information about the current subscription
    /// </summary>
    public interface ISubscriptionStorageProvider
    {
        /// <summary>
        /// Returns your current FXE license key
        /// </summary>
        /// <returns></returns>
        string GetLicenseKey();
        
        /// <summary>
        /// Reads the current subscription usage from the underlying store
        /// </summary>
        /// <returns>An object with all the current subscription usage data</returns>
        ISubscriptionUsage Read();
        
        /// <summary>
        /// Writes the current subscription usage back to the underlying data store
        /// </summary>
        /// <param name="currentUsage">The current usage to store</param>
        void Write(ISubscriptionUsage currentUsage);
    }
}