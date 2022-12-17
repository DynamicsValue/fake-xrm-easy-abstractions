namespace FakeXrmEasy.Abstractions.Enums.CustomApis
{
    /// <summary>
    /// Defines what types of plugin steps can be registered against the custom api
    /// </summary>
    public enum CustomProcessingStepType
    {
        /// <summary>
        /// Only the PluginType defined in the custom api will be allowed
        /// </summary>
        None = 0,

        /// <summary>
        /// Only async plugins will be allowed
        /// </summary>
        AsyncOnly = 1,

        /// <summary>
        /// Allow both sync and async plugins
        /// </summary>
        SyncAndAsync = 2
    }
}
