using FakeXrmEasy.Abstractions.Plugins.Enums;
using FakeXrmEasy.Abstractions.Plugins.Registration;
using System;
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
        public void Should_create_plugin_registration_step()
        {
            var pluginStepRegistration = new PluginStepRegistrationAttribute()
            {
                Id = Guid.NewGuid().ToString(),
                Rank = 2,
                Stage = ProcessingStepStage.Preoperation,
                Mode = ProcessingStepMode.Asynchronous,
                MessageName = "Create",
                EntityLogicalName = "account",
                FilteringAttributes = new string[] { }
            };
            Assert.Equal(2, pluginStepRegistration.Rank);
            Assert.Equal(ProcessingStepStage.Preoperation, pluginStepRegistration.Stage);
            Assert.Equal(ProcessingStepMode.Asynchronous, pluginStepRegistration.Mode);
            Assert.NotNull(pluginStepRegistration.Id);
            Assert.NotNull(pluginStepRegistration.FilteringAttributes);
            Assert.Equal("Create", pluginStepRegistration.MessageName);
            Assert.Equal("account", pluginStepRegistration.EntityLogicalName);
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

        [Fact]
        public void Should_create_plugin_registration_step_image_with_properties()
        {
            var pluginStepImageRegistration = new PluginStepImageRegistrationAttribute()
            {
                StepId = Guid.NewGuid().ToString(),
                Name = "PostImage",
                Attributes = new string[] { },
                ImageType = ProcessingStepImageType.PostImage
            };

            Assert.NotNull(pluginStepImageRegistration.StepId);
            Assert.NotNull(pluginStepImageRegistration.Name);
            Assert.Equal(ProcessingStepImageType.PostImage, pluginStepImageRegistration.ImageType);
            Assert.NotNull(pluginStepImageRegistration.Attributes);
        }
    }
}
