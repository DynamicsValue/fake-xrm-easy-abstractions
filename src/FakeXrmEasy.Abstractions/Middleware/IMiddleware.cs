using FakeXrmEasy.Abstractions.Enums;
using System;

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
        /// <param name="license"></param>
        /// <returns></returns>
        IMiddlewareBuilder SetLicense(FakeXrmEasyLicense license);
        
        /// <summary>
        /// Use this method to set your license key when using a commercial license
        /// </summary>
        /// <param name="licenseKey">The license key provided to you</param>
        /// <returns></returns>
        IMiddlewareBuilder SetLicenseKey(string licenseKey);

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
