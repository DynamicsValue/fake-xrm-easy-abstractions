

using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Middleware
{
    public delegate OrganizationResponse OrganizationRequestDelegate(IXrmFakedContext context, OrganizationRequest request);
}