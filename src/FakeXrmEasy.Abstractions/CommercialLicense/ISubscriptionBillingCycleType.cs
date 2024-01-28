namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Billing Cycle Type of a given subscription
    /// </summary>
    public enum SubscriptionBillingCycleType
    {
        /// <summary>
        /// Monthly: subscription billed per user/month
        /// </summary>
        Monthly = 0,
        /// <summary>
        /// Annual: subscription billed per user/year
        /// </summary>
        Annual = 1,
        /// <summary>
        /// PrePaid: The subscription is prepaid for a period different than one month or one year and is set in the StartDate and EndDate fields
        /// </summary>
        PrePaid = 2
    }
}