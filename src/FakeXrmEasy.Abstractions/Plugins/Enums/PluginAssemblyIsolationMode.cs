namespace FakeXrmEasy.Abstractions.Plugins.Enums
{
    /// <summary>
    /// Plugin Assembly Isolation Mode
    /// </summary>
    public enum PluginAssemblyIsolationMode 
    {
        /// <summary>
        /// Full-Trust
        /// </summary>
        None = 1,
        /// <summary>
        /// Isolated
        /// </summary>
        Sandbox = 2
    }
}