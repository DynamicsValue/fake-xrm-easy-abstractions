using FakeXrmEasy.Abstractions.Enums.CustomApis;
using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Common interface for both strongly-typed and late bound custom api executors
    /// </summary>
    public interface IBaseCustomApiFakeMessageExecutor
    {
        /// <summary>
        /// The plugin to execute, if specified
        /// </summary>
        IPlugin PluginType { get; }

        /// <summary>
        /// The message name of the OrganizationRequest that will trigger this custom api execution
        /// </summary>
        string MessageName { get; }

        /// <summary>
        /// The custom processing type of the custom api
        /// </summary>
        CustomProcessingStepType CustomProcessingType { get; }

        /// <summary>
        /// The binding type of the custom api
        /// </summary>
        BindingType BindingType { get; }

        /// <summary>
        /// EntityLogicalName if this custom api is bound to an Entity
        /// </summary>
        string EntityLogicalName { get; }
    }

    /// <summary>
    /// An early bound custom api fake message executor that can optionally define an IPlugin type to execute when the 
    /// message is executed
    /// </summary>
    public interface ICustomApiFakeMessageExecutor: IFakeMessageExecutor, IBaseCustomApiFakeMessageExecutor
    {
    }

    /// <summary>
    /// A late bound custom api fake message executor that can optionally define an IPlugin type to execute when the 
    /// message is executed
    /// </summary>
    public interface IGenericCustomApiFakeMessageExecutor : IGenericFakeMessageExecutor, IBaseCustomApiFakeMessageExecutor
    {
    }
}
