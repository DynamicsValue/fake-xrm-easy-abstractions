using FakeXrmEasy.Abstractions.FakeMessageExecutors;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.FakeMessageExecutors
{
    public class ExecutionMocksTests
    {
        [Fact]
        public void Should_create_new_instance()
        {
            var executionMocks = new ExecutionMocks();
            Assert.NotNull(executionMocks);
        }
    }
}
