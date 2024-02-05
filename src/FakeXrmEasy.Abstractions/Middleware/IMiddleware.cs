using FakeXrmEasy.Abstractions.Enums;
using System;
using FakeXrmEasy.Abstractions.CommercialLicense;

namespace FakeXrmEasy.Abstractions.Middleware
{
    /// <summary>
    /// The middleware builder is used to build a custom XrmFakedContext. 
    /// </summary>
    public interface IMiddlewareBuilder
    {
        /// <summary>
        /// Adds a custom setup action to the context. All the Add methods should be called before any Use method.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        IMiddlewareBuilder Add(Action<IXrmFakedContext> context);

        /// <summary>
        /// Use this method to choose between the available FakeXrmEasy licenses
        /// </summary>
        /// <param name="license">The license you choose based on your organisation and use case. If unsure, please check the licensing FAQ: https://dynamicsvalue.github.io/fake-xrm-easy-docs/licensing/faq/</param>
        /// <returns></returns>
        IMiddlewareBuilder SetLicense(FakeXrmEasyLicense license);
        
        /// <summary>
        /// Use this method to provide an implementation for a subscription storage provider when you are using a commercial license and have a license key 
        /// </summary>
        /// <param name="storageProvider">An implementation of a ISubscriptionStorageProvider that is capable of reading and writing subscription usage data as well as your license key</param>
        /// <param name="upgradeRequested">Set to true if you exceeded the number of users that your current subscription allows and you have already requested an upgrade to DynamicsValue via your organisation's established process</param>
        /// <param name="renewalRequested">Set to true if your subscription expired and you have already requested an renewal to DynamicsValue via your organisation's established process</param>
        /// <returns></returns>
        IMiddlewareBuilder SetSubscriptionStorageProvider(ISubscriptionStorageProvider storageProvider, bool upgradeRequested = false, bool renewalRequested = false);

        /// <summary>
        /// Adds a new delegate to the middleware. The order in which the delegates are "used" is important. They'll define the pipeline sequence basically.
        /// </summary>
        /// <param name="middleware"></param>
        /// <returns></returns>
        IMiddlewareBuilder Use(Func<OrganizationRequestDelegate, OrganizationRequestDelegate> middleware);

        /// <summary>
        /// Builds a new context with all the setup actions (Add) and Use methods defined.
        /// </summary>
        /// <returns></returns>
        IXrmFakedContext Build();
    }
}
