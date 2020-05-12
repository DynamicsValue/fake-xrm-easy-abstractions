using System;
using System.Collections.Generic;
using FakeXrmEasy.Abstractions.FakeMessageExecutors;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.FakeMessageExecutors
{
    public class MessageExecutorsTests
    {
        [Fact]
        public void Should_create_message_executors_instance()
        {
            var other = new Dictionary<Type, IFakeMessageExecutor>();
            var messageExecutors = new MessageExecutors(other);
            Assert.NotNull(messageExecutors);
        }
    }
}
