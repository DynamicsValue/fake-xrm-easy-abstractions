using System;

namespace FakeXrmEasy.Abstractions.CommercialLicense
{
    /// <summary>
    /// Info about the last time a given user used FakeXrmEasy
    /// </summary>
    public interface ISubscriptionUserInfo
    {
        /// <summary>
        /// The last time this user used FakeXrmEasy
        /// </summary>
        DateTime LastTimeUsed { get; set; }
        
        /// <summary>
        /// The user's username
        /// </summary>
        string UserName { get; set; }
    }
}