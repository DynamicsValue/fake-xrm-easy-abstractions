using FakeXrmEasy.Abstractions.Enums;
using FakeXrmEasy.Abstractions.Exceptions;
using Microsoft.Xrm.Sdk;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.Exceptions
{
    public class UnsupportedExceptionFactoryTests
    {
        [Fact]
        public void Should_return_open_source_exception_when_using_RPL()
        {
            var exception = UnsupportedExceptionFactory.New(FakeXrmEasyLicense.RPL_1_5, "Some message");
            Assert.IsType<OpenSourceUnsupportedException>(exception);
            Assert.Contains("Some message", exception.Message);
        }

        [Fact]
        public void Should_return_commercial_exception_when_using_commercial()
        {
            var exception = UnsupportedExceptionFactory.New(FakeXrmEasyLicense.Commercial, "Some message");
            Assert.IsType<CommercialUnsupportedException>(exception);
            Assert.Contains("Some message", exception.Message);
        }

        [Fact]
        public void Should_return_non_commercial_exception_when_using_non_commercial()
        {
            var exception = UnsupportedExceptionFactory.New(FakeXrmEasyLicense.NonCommercial, "Some message");
            Assert.IsType<NonCommercialUnsupportedException>(exception);
            Assert.Contains("Some message", exception.Message);
        }

        [Fact]
        public void Should_create_not_implemented_organization_request()
        {
            var exception = UnsupportedExceptionFactory.NotImplementedOrganizationRequest(FakeXrmEasyLicense.RPL_1_5, typeof(OrganizationRequest));
            Assert.NotNull(exception);
            Assert.Contains($"{typeof(OrganizationRequest)}", exception.Message);
        }

        [Fact]
        public void Should_create_not_partialy_implemented_organization_request()
        {
            var missingImplementationMessage = "This implementation doesn't yet contain this feature";
            var exception = UnsupportedExceptionFactory.PartiallyNotImplementedOrganizationRequest(FakeXrmEasyLicense.RPL_1_5, typeof(OrganizationRequest), missingImplementationMessage);
            Assert.NotNull(exception);
            Assert.Contains(missingImplementationMessage, exception.Message);
        }

        [Fact]
        public void Should_create_fetchxml_operator_not_implemented()
        {
            var exception = UnsupportedExceptionFactory.FetchXmlOperatorNotImplemented(FakeXrmEasyLicense.RPL_1_5, "eq");
            Assert.NotNull(exception);
            Assert.Contains("operator 'eq'", exception.Message);
        }
    }
}
