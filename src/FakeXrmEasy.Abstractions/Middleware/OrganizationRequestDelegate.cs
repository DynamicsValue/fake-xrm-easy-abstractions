

using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Middleware
{
    /// <summary>
    /// Organization Request Mock Delegate
    /// </summary>
    /// <param name="context"></param>
    /// <param name="request"></param>
    /// <returns></returns>
    public delegate OrganizationResponse OrganizationRequestDelegate(IXrmFakedContext context, OrganizationRequest request);
}