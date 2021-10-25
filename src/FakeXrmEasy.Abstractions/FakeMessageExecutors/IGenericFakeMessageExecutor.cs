namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// An interface that adds an additional method in order to discover generic requests by name
    /// </summary>
    public interface IGenericFakeMessageExecutor : IBaseFakeMessageExecutor
    {
        /// <summary>
        /// The OrganizationRequest's RequestName property
        /// </summary>
        /// <returns></returns>
        string GetRequestName();
    }
}