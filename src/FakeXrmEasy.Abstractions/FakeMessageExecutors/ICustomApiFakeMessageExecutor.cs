using Microsoft.Xrm.Sdk;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// An early bound api fake message executor can optionally define an IPlugin type to execute when the 
    /// message is executed
    /// </summary>
    public interface ICustomApiFakeMessageExecutor: IFakeMessageExecutor
    {
        /// <summary>
        /// The plugin to execute, if specified
        /// </summary>
        IPlugin PluginType { get; set; }
    }

    /// <summary>
    /// A late bound custom api fake message executor can optionally define an IPlugin type to execute when the 
    /// message is executed
    /// </summary>
    public interface IGenericCustomApiFakeMessageExecutor : IGenericFakeMessageExecutor
    {
        /// <summary>
        /// The plugin to execute, if specified
        /// </summary>
        IPlugin PluginType { get; set; }
    }
}
