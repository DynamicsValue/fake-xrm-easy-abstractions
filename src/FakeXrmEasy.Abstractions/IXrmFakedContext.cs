using FakeXrmEasy.Abstractions.Plugins;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FakeXrmEasy.Abstractions
{
    public interface IXrmFakedContext: IXrmBaseContext
    {
        /// <summary>
        /// Returns the caller properties, that is, the default user and business unit used to impersonate service calls
        /// </summary>
        ICallerProperties CallerProperties { get; set; }

        /// <summary>
        /// Returns an instance of a tracing service
        /// </summary>
        /// <returns></returns>
        ITracingService GetTracingService();

        /// <summary>
        /// Creates a queryable for a strongly-typed entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IQueryable<T> CreateQuery<T>() where T : Entity;

        /// <summary>
        /// Creates a queryable for a late bound entity
        /// </summary>
        /// <param name="logicalName"></param>
        /// <returns></returns>
        IQueryable<Entity> CreateQuery(string logicalName);

        /// <summary>
        /// Retrieves an entity by primary key as currently stored in the in-memory database.
        /// Useful if you want to bypass a retrieve message, and simpler than using CreateQuery.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetEntityById<T>(Guid id) where T: Entity;

        /// <summary>
        /// Same as GetEntityById<T> but for late bound entities
        /// </summary>
        /// <param name="logicalName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        Entity GetEntityById(string logicalName, Guid id);

        /// <summary>
        /// Returns true if record of the logicalName and id exists in the in-memory database
        /// </summary>
        /// <param name="logicalName"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        bool ContainsEntity(string logicalName, Guid id);

        /// <summary>
        /// Receives a list of entities, that are used to initialize the context with those
        /// </summary>
        /// <param name="entities"></param>
        void Initialize(IEnumerable<Entity> entities);
        
        /// Initializes the context with a single entity when only one is needed
        void Initialize(Entity entity);

        IXrmFakedPluginContextProperties PluginContextProperties { get; set; }

        void AddEntity(Entity e);
        void AddEntityWithDefaults(Entity e, bool clone = false, bool usePluginPipeline = false);
        Guid CreateEntity(Entity e);
        void UpdateEntity(Entity e);
        void DeleteEntity(EntityReference er);
        
        
        Type FindReflectedType(string logicalName);
        Type FindReflectedAttributeType(Type earlyBoundType, string sEntityName, string attributeName);

        void EnableProxyTypes(Assembly assembly);
        IEnumerable<Assembly> ProxyTypesAssemblies { get; }
        void InitializeMetadata(IEnumerable<EntityMetadata> entityMetadataList);
        void InitializeMetadata(EntityMetadata entityMetadata);
        void InitializeMetadata(Assembly earlyBoundEntitiesAssembly);
        IQueryable<EntityMetadata> CreateMetadataQuery();
        EntityMetadata GetEntityMetadataByName(string sLogicalName);
        void SetEntityMetadata(EntityMetadata em);
        void AddRelationship(string schemaname, XrmFakedRelationship relationship);
        void RemoveRelationship(string schemaname);
        XrmFakedRelationship GetRelationship(string schemaName);
        IEnumerable<XrmFakedRelationship> Relationships { get; }

        Guid GetRecordUniqueId(EntityReference record, bool validate = true);
    }
}