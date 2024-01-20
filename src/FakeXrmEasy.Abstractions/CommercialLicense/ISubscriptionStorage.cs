using System.Threading.Tasks;

namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Provides an abstraction to store information about the current subscription
    /// </summary>
    public interface ISubscriptionStorage
    {
        /// <summary>
        /// Reads the current subscription usage from the underlying store
        /// </summary>
        /// <returns>An object with all the current subscription usage data</returns>
        Task<ISubscriptionUsage> ReadAsync();
        
        /// <summary>
        /// Writes the current subscription usage back to the underlying data store
        /// </summary>
        /// <param name="currentUsage">The current usage to store</param>
        Task WriteAsync(ISubscriptionUsage currentUsage);
    }
}