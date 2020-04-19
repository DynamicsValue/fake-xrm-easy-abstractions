using FakeXrmEasy.Abstractions.Plugins;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;
using System.Linq;

namespace FakeXrmEasy.Abstractions
{
    public interface IXrmFakedContext: IXrmBaseContext
    {
        /// <summary>
        /// Receives a list of entities, that are used to initialize the context with those
        /// </summary>
        /// <param name="entities"></param>
        void Initialize(IEnumerable<Entity> entities);


        /// <summary>
        /// Receives a strong-typed entity type and returns a Queryable of that type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> CreateQuery<T>()
            where T : Entity;

        
        ICallerProperties CallerProperties { get; set; }
        IXrmFakedPluginContextProperties PluginContextProperties { get; set; }
    }
}