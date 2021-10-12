using FakeXrmEasy.Abstractions.Enums;
using System;

namespace FakeXrmEasy.Abstractions.Middleware
{
    public interface IMiddlewareBuilder
    {
        IMiddlewareBuilder SetLicense(FakeXrmEasyLicense license);
        IMiddlewareBuilder Add(Action<IXrmFakedContext> context);
        IMiddlewareBuilder Use(Func<OrganizationRequestDelegate, OrganizationRequestDelegate> middleware);

        IXrmFakedContext Build();
    }
}
