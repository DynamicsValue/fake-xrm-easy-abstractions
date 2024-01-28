using System;

namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Provides a way to tell an upgrade has already been requested and to enable a 30-day upgrade window
    /// </summary>
    public interface ISubscriptionUpgradeRequest
    {
        /// <summary>
        /// The date when the upgrade was requested
        /// </summary>
        DateTime FirstRequestDate { get; set; }
        
        /// <summary>
        /// The original number of users that triggered the upgrade and that is now exceeded
        /// </summary>
        long PreviousNumberOfUsers { get; set; }
    }
}