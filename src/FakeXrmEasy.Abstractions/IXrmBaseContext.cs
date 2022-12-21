using FakeXrmEasy.Abstractions.Enums;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
    /// <summary>
    /// Base context interface with shared methods across XrmFakedContext and XrmRealContext classes.
    /// </summary>
    public interface IXrmBaseContext 
    {
        /// <summary>
        /// Sets the chosen software license in the FakeXrmEasy framework
        /// </summary>
        FakeXrmEasyLicense? LicenseContext { get; set; }

        /// <summary>
        /// Returns an instance of an organization service
        /// </summary>
        /// <returns></returns>
        IOrganizationService GetOrganizationService();

        /// <summary>
        /// Returns an instance of an organization service whith async support but without cancellation tokens
        /// </summary>
        /// <returns></returns>
        IOrganizationServiceAsync GetAsyncOrganizationService();

        /// <summary>
        /// Returns an instance of an organization service whith async support with cancellation tokens
        /// </summary>
        /// <returns></returns>
        IOrganizationServiceAsync2 GetAsyncOrganizationService2();

        /// <summary>
        /// Set a value of a specific custom property of a given type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        void SetProperty<T>(T property);

        /// <summary>
        /// Returns a custom property
        /// </summary>
        /// <returns>The property requested or exception if property wasn't set before</returns>
        T GetProperty<T>();

        /// <summary>
        /// Method to check if a custom property exists. True if property was set, false otherwise
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        bool HasProperty<T>();

        /// <summary>
        /// Returns the caller properties, that is, the default user and business unit used to impersonate service calls
        /// </summary>
        ICallerProperties CallerProperties { get; set; }

        /// <summary>
        /// Returns an instance of a tracing service
        /// </summary>
        /// <returns></returns>
        IXrmFakedTracingService GetTracingService();

        /// <summary>
        /// PluginContext Properties
        /// </summary>
        IXrmFakedPluginContextProperties PluginContextProperties { get; set; }
    }
}