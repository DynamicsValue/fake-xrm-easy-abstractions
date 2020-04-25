using System;
using System.Threading.Tasks;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.Middleware
{
    public interface IMiddlewareBuilder
    {
        IMiddlewareBuilder Add(Action<IXrmFakedContext> context);
        IMiddlewareBuilder Use(Func<OrganizationRequestDelegate, OrganizationRequestDelegate> middleware);

        IXrmFakedContext Build();
    }
}
