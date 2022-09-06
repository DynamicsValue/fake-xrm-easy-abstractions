using FakeXrmEasy.Abstractions.Plugins.Registration;
using Microsoft.Xrm.Sdk;
using System;

namespace FakeXrmEasy.Abstractions.Tests.Plugins
{
    #region Registration
    internal class SimplePluginRegistrationConstants
    {
        internal const string SimplePluginCreateStepId = "20634321-8B64-4F00-951D-02687E626FDB";
    }

    [PluginStepRegistration(
        MessageName = "Create",
        Id = SimplePluginRegistrationConstants.SimplePluginCreateStepId,
        EntityLogicalName = "account", 
        FilteringAttributes = new string[] { "name" }
    )]
    [PluginStepImageRegistration(
        Name = "PreImage",
        StepId = SimplePluginRegistrationConstants.SimplePluginCreateStepId,
        Attributes = new string[] { "name" }
    )]
    [PluginStepImageRegistration(
        Name = "PostImage",
        StepId = SimplePluginRegistrationConstants.SimplePluginCreateStepId,
        Attributes = new string[] { "name" }
    )]
    #endregion
    public class SimplePlugin : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            throw new NotImplementedException();
        }
    }
}
