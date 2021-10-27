
using System;
using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Contains a collection of FakeMessageExecutors indexed by the concrete type of OrganizationRequest
    /// </summary>
    public class MessageExecutors : Dictionary<Type, IFakeMessageExecutor>
    {
        /// <summary>
        /// Creates an empty collection
        /// </summary>
        public MessageExecutors()
        {

        }

        /// <summary>
        /// Construtor from a predefined dictionary with FakeMessageExecutors in it
        /// </summary>
        /// <param name="other"></param>
        public MessageExecutors(Dictionary<Type, IFakeMessageExecutor> other): base(other)
        {
            
        }
    }
}