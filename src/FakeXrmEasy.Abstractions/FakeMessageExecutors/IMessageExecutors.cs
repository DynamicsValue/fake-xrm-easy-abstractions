
using System;
using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.FakeMessageExecutors
{
    public interface IMessageExecutors: IDictionary<Type, IFakeMessageExecutor>
    {
        
    }
}