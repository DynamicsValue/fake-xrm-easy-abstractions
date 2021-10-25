

using System;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// An interface to delegate custom messages to be executed via a IOrganizationService.Execute method.
    /// Each executor is in charge of encapsulating a single request and declare which requests can handle via de CanExecute method
    /// </summary>
    public interface IFakeMessageExecutor: IBaseFakeMessageExecutor
    {
        /// <summary>
        /// The concrete OrganizationRequest type that this executor is in charge of executing
        /// </summary>
        /// <returns></returns>
        Type GetResponsibleRequestType();
    }
}