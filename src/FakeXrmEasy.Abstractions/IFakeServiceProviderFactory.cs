
using System;

namespace FakeXrmEasy.Abstractions 
{
    public interface IFakeServiceProviderFactory 
    {
        IServiceProvider GetServiceProvider();
    }
}