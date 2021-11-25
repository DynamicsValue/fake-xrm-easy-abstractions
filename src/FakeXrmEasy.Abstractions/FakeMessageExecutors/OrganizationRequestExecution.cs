
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Organization Request Mock Delegate
    /// </summary>
    /// <param name="req"></param>
    /// <returns></returns>
    public delegate OrganizationResponse OrganizationRequestExecution(OrganizationRequest req);
}