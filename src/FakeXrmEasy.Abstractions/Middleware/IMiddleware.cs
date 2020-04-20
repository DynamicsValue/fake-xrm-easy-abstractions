using System;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Middleware
{
    public interface IMiddlewareBuilder
    {
        IMiddlewareBuilder Add(Func<IXrmFakedContext, OrganizationRequest, Func<IXrmFakedContext, OrganizationRequest, OrganizationResponse>, OrganizationResponse> funcOrNext);

        IMiddlewareBuilder AddCrud();
        IMiddlewareBuilder AddFakeMessages();
        IXrmFakedContext Build();
    }
}
