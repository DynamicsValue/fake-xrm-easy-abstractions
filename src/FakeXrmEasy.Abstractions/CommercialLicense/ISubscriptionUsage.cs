using System;
using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Represents the current subscription usage
    /// </summary>
    public interface ISubscriptionUsage
    {
        /// <summary>
        /// The last time the current subscription usage was checked
        /// </summary>
        DateTime LastTimeChecked { get; set; }
        
        /// <summary>
        /// Information about all the users using FakeXrmEasy
        /// </summary>
        ICollection<ISubscriptionUserInfo> Users { get; set; }
        
        /// <summary>
        /// Contains information when an upgrade has been requested
        /// </summary>
        ISubscriptionUpgradeRequest UpgradeInfo { get; set; }
    }
}