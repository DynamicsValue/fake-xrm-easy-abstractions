using System.Collections.Generic;
using FakeXrmEasy.Abstractions.FakeMessageExecutors;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.FakeMessageExecutors
{
    public class GenericMessageExecutorsTests
    {
        [Fact]
        public void Should_create_empty_generic_message_executors_collection()
        {
            var messageExecutors = new GenericMessageExecutors();
            Assert.NotNull(messageExecutors);
        }

        [Fact]
        public void Should_create_message_executors_instance()
        {
            var other = new Dictionary<string, IFakeMessageExecutor>();
            var messageExecutors = new GenericMessageExecutors(other);
            Assert.NotNull(messageExecutors);
        }
    }
}
