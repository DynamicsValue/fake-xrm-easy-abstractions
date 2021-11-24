namespace FakeXrmEasy.Abstractions 
{
    /// <summary>
    /// Real Context for Integration Testing
    /// </summary>
    public interface IXrmRealContext: IXrmBaseContext 
    {
        /// <summary>
        /// Connection String to connect to the real instance
        /// </summary>
        string ConnectionStringName { get; set; }
    }
}