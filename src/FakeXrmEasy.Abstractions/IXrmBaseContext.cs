using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions
{
    public interface IXrmBaseContext 
    {
        /// <summary>
        /// Returns an instance of an organization service
        /// </summary>
        /// <returns></returns>
        IOrganizationService GetOrganizationService();
    }
}