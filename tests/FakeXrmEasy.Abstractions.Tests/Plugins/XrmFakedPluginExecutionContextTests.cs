using FakeXrmEasy.Abstractions.Plugins;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.Plugins
{
    public class XrmFakedPluginExecutionContextTests
    {
        [Fact]
        public void Should_set_default_plugin_context_properties()
        {
            var plugCtx = new XrmFakedPluginExecutionContext();

            Assert.Equal(1, plugCtx.Depth);
            Assert.Equal(1, plugCtx.IsolationMode);
            Assert.False(plugCtx.IsExecutingOffline);
            Assert.Equal("Create", plugCtx.MessageName);
        }
    }
}
