using FakeXrmEasy.Abstractions.FakeMessageExecutors;
using System.Collections.Generic;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.FakeMessageExecutors
{
    public class CustomApiFakeMessageExecutorsTests
    {
        [Fact]
        public void Should_create_empty_collection()
        {
            var executors = new CustomApiFakeMessageExecutors();
            Assert.NotNull(executors);
        }

        [Fact]
        public void Should_create_message_executors_instance()
        {
            var other = new Dictionary<string, IBaseCustomApiFakeMessageExecutor>();
            var executors = new CustomApiFakeMessageExecutors(other);
            Assert.NotNull(executors);
        }
    }
}
