using System;
using FakeXrmEasy.Abstractions.Plugins;
using FakeXrmEasy.Abstractions.Plugins.Enums;
using Xunit;
using Microsoft.Xrm.Sdk;

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

        [Fact]
        public void Should_set_default_plugin_context_in_transaction_based_on_stage_and_mode()
        {
            var plugCtx = new XrmFakedPluginExecutionContext();

            Assert.False(plugCtx.IsInTransaction);

            plugCtx.Stage = (int) ProcessingStepStage.Preoperation;
            Assert.True(plugCtx.IsInTransaction);

            plugCtx.Stage = (int) ProcessingStepStage.Postoperation;
            plugCtx.Mode = (int) ProcessingStepMode.Synchronous;
            Assert.True(plugCtx.IsInTransaction);

            plugCtx.Stage = (int) ProcessingStepStage.Postoperation;
            plugCtx.Mode = (int) ProcessingStepMode.Asynchronous;
            Assert.False(plugCtx.IsInTransaction);
        }

        [Fact]
        public void Should_set_default_plugin_context_with_custom_properties()
        {
            var plugCtx = new XrmFakedPluginExecutionContext();

            var businessUnitId = Guid.NewGuid();

            plugCtx.BusinessUnitId = businessUnitId;
            plugCtx.CorrelationId = Guid.NewGuid();
            plugCtx.Depth = 2;
            plugCtx.InitiatingUserId = Guid.NewGuid();
            plugCtx.InputParameters = new ParameterCollection();
            plugCtx.IsOfflinePlayback = false;
            plugCtx.IsolationMode = (int) PluginAssemblyIsolationMode.None;
            plugCtx.MessageName= "Update";
            plugCtx.Mode = (int) ProcessingStepMode.Synchronous;
            plugCtx.OperationCreatedOn = DateTime.UtcNow;
            plugCtx.OperationId = Guid.NewGuid();
            plugCtx.OrganizationId = Guid.NewGuid();
            plugCtx.OrganizationName = "Contoso";
            plugCtx.OutputParameters = new ParameterCollection();
            plugCtx.OwningExtension = new EntityReference();
            plugCtx.PostEntityImages = new EntityImageCollection();
            plugCtx.PreEntityImages = new EntityImageCollection();
            plugCtx.PrimaryEntityId = Guid.NewGuid();
            plugCtx.PrimaryEntityName = "account";
            plugCtx.RequestId = Guid.NewGuid();
            plugCtx.SecondaryEntityName = "";
            plugCtx.SharedVariables = new ParameterCollection();
            plugCtx.UserId = Guid.NewGuid();
            plugCtx.ParentContext = new XrmFakedPluginExecutionContext();
            plugCtx.Stage = (int) ProcessingStepStage.Preoperation;
 
            Assert.Equal(2, plugCtx.Depth);
            Assert.Equal(businessUnitId, plugCtx.BusinessUnitId);

        }
    }
}
