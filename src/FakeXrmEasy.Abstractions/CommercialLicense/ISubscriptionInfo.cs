using System;

namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Contains info about the current subscription
    /// </summary>
    public interface ISubscriptionInfo
    {
        /// <summary>
        /// SKU of the product this subscription represents
        /// </summary>
        StockKeepingUnits SKU { get; set; }
        
        /// <summary>
        /// True if the current subscription auto-renews 
        /// </summary>
        bool AutoRenews { get; set; }
        
        /// <summary>
        /// The current billing cycle type
        /// </summary>
        SubscriptionBillingCycleType BillingType { get; set; }
        
        /// <summary>
        /// Max number of users allowed in the current subscription
        /// </summary>
        long NumberOfUsers { get; set; }
        
        /// <summary>
        /// The subscription start date
        /// </summary>
        DateTime StartDate { get; set; }
        
        /// <summary>
        /// The subscription's end date
        /// </summary>
        DateTime EndDate { get; set; }
    }
}