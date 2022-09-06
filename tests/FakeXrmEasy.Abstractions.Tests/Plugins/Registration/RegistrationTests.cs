using FakeXrmEasy.Abstractions.Plugins.Enums;
using FakeXrmEasy.Abstractions.Plugins.Registration;
using Xunit;

namespace FakeXrmEasy.Abstractions.Tests.Plugins.Registration
{
    public class RegistrationTests
    {
        [Fact]
        public void Should_create_plugin_registration_step_with_default_attributes()
        {
            var pluginStepRegistration = new PluginStepRegistrationAttribute();
            Assert.Equal(1, pluginStepRegistration.Rank);
            Assert.Equal(ProcessingStepStage.Postoperation, pluginStepRegistration.Stage);
            Assert.Equal(ProcessingStepMode.Synchronous, pluginStepRegistration.Mode);
            Assert.Null(pluginStepRegistration.Id);
            Assert.Null(pluginStepRegistration.FilteringAttributes);
            Assert.Null(pluginStepRegistration.MessageName);
            Assert.Null(pluginStepRegistration.EntityLogicalName);
        }

        [Fact]
        public void Should_create_plugin_registration_step_image_with_defaults()
        {
            var pluginStepImageRegistration = new PluginStepImageRegistrationAttribute();
            Assert.NotNull(pluginStepImageRegistration);

            Assert.Null(pluginStepImageRegistration.StepId);
            Assert.Null(pluginStepImageRegistration.Name);
            Assert.Equal(ProcessingStepImageType.PreImage, pluginStepImageRegistration.ImageType);
            Assert.Null(pluginStepImageRegistration.Attributes);
        }
    }
}
