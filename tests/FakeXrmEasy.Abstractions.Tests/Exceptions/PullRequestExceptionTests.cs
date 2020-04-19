using FakeXrmEasy.Abstractions.Exceptions;
using Microsoft.Xrm.Sdk;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.Exceptions
{
    public class PullRequestExceptionTests
    
    {
        [Fact]
        public void Should_create_pull_request_exception_with_message() 
        {
            var message = "Some message";
            var pullRequestException = new PullRequestException(message);
            Assert.Contains(message, pullRequestException.Message);
        }

        [Fact]
        public void Should_create_not_implemented_organization_request() 
        {
            var pullRequestException = PullRequestException.NotImplementedOrganizationRequest(typeof(OrganizationRequest));
            Assert.NotNull(pullRequestException);
        }

        [Fact]
        public void Should_create_not_partialy_implemented_organization_request() 
        {
            var missingImplementationMessage = "This implementation doesn't yet contain this feature";
            var pullRequestException = PullRequestException.PartiallyNotImplementedOrganizationRequest(typeof(OrganizationRequest), missingImplementationMessage);
            Assert.NotNull(pullRequestException);
            Assert.Contains(missingImplementationMessage, pullRequestException.Message);
        }

        [Fact]
        public void Should_create_fetchxml_operator_not_implemented() 
        {
            var pullRequestException = PullRequestException.FetchXmlOperatorNotImplemented("eq");
            Assert.NotNull(pullRequestException);
            Assert.Contains("operator 'eq'", pullRequestException.Message);
        }

    }
}
