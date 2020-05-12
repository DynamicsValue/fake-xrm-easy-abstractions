
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    public delegate OrganizationResponse OrganizationRequestExecution(OrganizationRequest req);
}