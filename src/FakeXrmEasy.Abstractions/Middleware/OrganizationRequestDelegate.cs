

using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Middleware
{
    public delegate OrganizationResponse OrganizationRequestDelegate(OrganizationRequestDelegate request);
}