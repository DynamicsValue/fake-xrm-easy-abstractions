using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Abstractions.Exceptions;
using FakeXrmEasy.Abstractions.Plugins;
using Microsoft.PowerPlatform.Dataverse.Client;
using Microsoft.Xrm.Sdk;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.Exceptions
{
    public class LicenseExceptionTests
    {
        private class DummyXrmContext : IXrmBaseContext
        {
            public FakeXrmEasyLicense? LicenseContext { get; set; }

            public IOrganizationServiceAsync GetAsyncOrganizationService()
            {
                throw new System.NotImplementedException();
            }

            public IOrganizationServiceAsync2 GetAsyncOrganizationService2()
            {
                throw new System.NotImplementedException();
            }

            public IOrganizationService GetOrganizationService()
            {
                throw new System.NotImplementedException();
            }

            public T GetProperty<T>()
            {
                throw new System.NotImplementedException();
            }

            public IXrmFakedTracingService GetTracingService()
            {
                throw new System.NotImplementedException();
            }

            public bool HasProperty<T>()
            {
                throw new System.NotImplementedException();
            }

            public void SetProperty<T>(T property)
            {
                throw new System.NotImplementedException();
            }

            public ICallerProperties CallerProperties { get; set; }
            public IXrmFakedPluginContextProperties PluginContextProperties { get; set; }
        }

        [Fact]
        public void Should_create_license_exception_with_message()
        {
            var message = "Some message";
            var exception = new LicenseException(message);
            Assert.Contains(message, exception.Message);
        }

        [Fact]
        public void Should_not_set_a_default_license_context()
        {
            Assert.Null(new DummyXrmContext().LicenseContext);
        }
    }
}
