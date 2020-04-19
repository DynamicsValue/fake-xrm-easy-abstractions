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

            var operationCreatedOn = DateTime.UtcNow;
            var businessUnitId = Guid.NewGuid();
            var correlationId = Guid.NewGuid();
            var initiatinUserId = Guid.NewGuid();
            var inputParameters = new ParameterCollection();
            var outputParameters = new ParameterCollection();
            var sharedVariables = new ParameterCollection();
            var operationId = new Guid();
            var organizationId = new Guid();
            var owningExtension = new EntityReference();
            var postEntityImages = new EntityImageCollection();
            var preEntityImages = new EntityImageCollection();
            var parentPluginContext = new XrmFakedPluginExecutionContext();
            var primaryEntityId = Guid.NewGuid();
            var requestId = Guid.NewGuid();
            var userId = Guid.NewGuid();

            plugCtx.BusinessUnitId = businessUnitId;
            plugCtx.CorrelationId = correlationId;
            plugCtx.Depth = 2;
            plugCtx.InitiatingUserId = initiatinUserId;
            plugCtx.InputParameters = inputParameters;
            plugCtx.IsOfflinePlayback = false;
            plugCtx.IsolationMode = (int) PluginAssemblyIsolationMode.None;
            plugCtx.MessageName = "Update";
            plugCtx.Mode = (int) ProcessingStepMode.Synchronous;
            plugCtx.OperationCreatedOn = operationCreatedOn;
            plugCtx.OperationId = operationId;
            plugCtx.OrganizationId = organizationId;
            plugCtx.OrganizationName = "Contoso";
            plugCtx.OutputParameters = outputParameters;
            plugCtx.OwningExtension = owningExtension;
            plugCtx.PostEntityImages = postEntityImages;
            plugCtx.PreEntityImages = preEntityImages;
            plugCtx.PrimaryEntityId = primaryEntityId;
            plugCtx.PrimaryEntityName = "account";
            plugCtx.RequestId = requestId;
            plugCtx.SecondaryEntityName = "";
            plugCtx.SharedVariables = sharedVariables;
            plugCtx.UserId = userId;
            plugCtx.ParentContext = parentPluginContext;
            plugCtx.Stage = (int) ProcessingStepStage.Preoperation;
 
            Assert.Equal(businessUnitId, plugCtx.BusinessUnitId);
            Assert.Equal(correlationId, plugCtx.CorrelationId);
            Assert.Equal(2, plugCtx.Depth);
            Assert.Equal(initiatinUserId, plugCtx.InitiatingUserId);
            Assert.Equal(inputParameters, plugCtx.InputParameters);
            Assert.False(plugCtx.IsOfflinePlayback);
            Assert.Equal((int) PluginAssemblyIsolationMode.None, plugCtx.IsolationMode);
            Assert.Equal("Update", plugCtx.MessageName);
            Assert.Equal((int) ProcessingStepMode.Synchronous, plugCtx.Mode);
            Assert.Equal(operationCreatedOn, plugCtx.OperationCreatedOn);
            Assert.Equal(operationId, plugCtx.OperationId);
            Assert.Equal(organizationId, plugCtx.OrganizationId);
            Assert.Equal("Contoso", plugCtx.OrganizationName);
            Assert.Equal(outputParameters, plugCtx.OutputParameters);
            Assert.Equal(owningExtension, plugCtx.OwningExtension);
            Assert.Equal(postEntityImages,plugCtx.PostEntityImages);
            Assert.Equal(preEntityImages, plugCtx.PreEntityImages);
            Assert.Equal(primaryEntityId, plugCtx.PrimaryEntityId);
            Assert.Equal("account", plugCtx.PrimaryEntityName);
            Assert.Equal(requestId, plugCtx.RequestId);
            Assert.Equal("", plugCtx.SecondaryEntityName);
            Assert.Equal(sharedVariables, plugCtx.SharedVariables);
            Assert.Equal(userId, plugCtx.UserId);
            Assert.Equal(parentPluginContext, plugCtx.ParentContext);
            Assert.Equal((int) ProcessingStepStage.Preoperation, plugCtx.Stage);
        }
    }
}
