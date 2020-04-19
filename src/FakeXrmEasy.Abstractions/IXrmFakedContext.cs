using FakeXrmEasy.Abstractions.Plugins;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FakeXrmEasy.Abstractions
{
    public interface IXrmFakedContext: IXrmBaseContext
    {
        ICallerProperties CallerProperties { get; set; }

        /// <summary>
        /// Receives a strong-typed entity type and returns a Queryable of that type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> CreateQuery<T>() where T : Entity;
        IQueryable<Entity> CreateQuery(string logicalName);

        /// <summary>
        /// Receives a list of entities, that are used to initialize the context with those
        /// </summary>
        /// <param name="entities"></param>
        void Initialize(IEnumerable<Entity> entities);
        
        IXrmFakedPluginContextProperties PluginContextProperties { get; set; }

        void AddEntity(Entity e);
        void AddEntityWithDefaults(Entity e, bool clone = false, bool usePluginPipeline = false);
        void UpdateEntity(Entity e);
        void DeleteEntity(EntityReference er);

        Type FindReflectedType(string logicalName);
    }
}