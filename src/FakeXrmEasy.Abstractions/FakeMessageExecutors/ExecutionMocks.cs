
using System;
using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    /// <summary>
    /// Contains a collection of execution mocks indexed by the type of OrganizationRequest
    /// </summary>
    public class ExecutionMocks : Dictionary<Type, OrganizationRequestExecution>
    {
        public ExecutionMocks() { }
    }
}