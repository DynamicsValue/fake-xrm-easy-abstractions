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
        /// The message name that will trigger this custom api execution
        /// </summary>
        string MessageName { get; }
    }

    /// <summary>
    /// An early bound api fake message executor can optionally define an IPlugin type to execute when the 
    /// message is executed
    /// </summary>
    public interface ICustomApiFakeMessageExecutor: IFakeMessageExecutor, IBaseCustomApiFakeMessageExecutor
    {
    }

    /// <summary>
    /// A late bound custom api fake message executor can optionally define an IPlugin type to execute when the 
    /// message is executed
    /// </summary>
    public interface IGenericCustomApiFakeMessageExecutor : IGenericFakeMessageExecutor, IBaseCustomApiFakeMessageExecutor
    {
    }
}
