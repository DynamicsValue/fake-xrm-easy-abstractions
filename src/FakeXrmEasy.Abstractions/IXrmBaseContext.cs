using FakeXrmEasy.Abstractions.Enums;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
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
        IOrganizationService GetAsyncOrganizationService();

        /// <summary>
        /// Returns an instance of an organization service whith async support with cancellation tokens
        /// </summary>
        /// <returns></returns>
        IOrganizationService GetAsyncOrganizationService2();

        //Set a value of a specific custom property of a given type
        void SetProperty<T>(T property);

        /// <summary>
        /// Returns a custom property
        /// </summary>
        /// <returns>The property requested or exception if property wasn't set before</returns>
        T GetProperty<T>();

        //True if property was set, false otherwise
        bool HasProperty<T>();
    }
}