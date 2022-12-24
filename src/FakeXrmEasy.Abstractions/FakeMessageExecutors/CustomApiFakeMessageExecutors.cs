using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Holds a dictionary of all the fake custom api executors
    /// </summary>
    public class CustomApiFakeMessageExecutors : Dictionary<string, IBaseCustomApiFakeMessageExecutor>
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public CustomApiFakeMessageExecutors()
        {

        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="other"></param>
        public CustomApiFakeMessageExecutors(Dictionary<string, IBaseCustomApiFakeMessageExecutor> other): base(other)
        {

        }
    }
}
