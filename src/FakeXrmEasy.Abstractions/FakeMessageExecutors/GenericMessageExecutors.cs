
using System;
using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Stores generic message executors that do not necessarily have an associated stronly-typed OrganizationRequest, like, late bound custom actions,
    /// or even to simulate internal out of the box messages
    /// </summary>
    public class GenericMessageExecutors : Dictionary<string, IFakeMessageExecutor>
    {
        public GenericMessageExecutors(Dictionary<string, IFakeMessageExecutor> other): base(other)
        {
            
        }
    }
}