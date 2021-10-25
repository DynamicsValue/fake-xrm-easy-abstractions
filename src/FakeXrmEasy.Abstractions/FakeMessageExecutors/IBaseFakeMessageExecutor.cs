using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Base interface for fake messages
    /// </summary>
    public interface IBaseFakeMessageExecutor
    {
        /// <summary>
        /// Determines if the given OrganizationRequest can be executed by this executor
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool CanExecute(OrganizationRequest request);

        /// <summary>
        /// Executes the OrganizationRequest according to the current executor implementation
        /// </summary>
        /// <param name="request"></param>
        /// <param name="ctx"></param>
        /// <returns></returns>
        OrganizationResponse Execute(OrganizationRequest request, IXrmFakedContext ctx);
    }
}