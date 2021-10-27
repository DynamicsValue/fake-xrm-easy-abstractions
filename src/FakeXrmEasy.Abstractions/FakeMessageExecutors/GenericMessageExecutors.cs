using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Stores generic message executors that do not necessarily have an associated stronly-typed OrganizationRequest, like, late bound custom actions,
    /// or even to simulate internal out of the box messages.
    /// 
    /// GenericFakeMessages are a dictionary of IFakeMessageExecutor instead of IGenericFakeMessageExecutors for backwards compatibility with previous versions.
    /// In the next major version this will likely change
    /// </summary>
    public class GenericMessageExecutors : Dictionary<string, IFakeMessageExecutor>
    {
        /// <summary>
        /// Empty constructor: constructs an empty collection of generic fake message executors
        /// </summary>
        public GenericMessageExecutors()
        {

        }

        /// <summary>
        /// Copy constructor that constructs a new instance copying of another dictionary of generic fake message executors
        /// </summary>
        /// <param name="other"></param>
        public GenericMessageExecutors(Dictionary<string, IFakeMessageExecutor> other): base(other)
        {
            
        }
    }
}