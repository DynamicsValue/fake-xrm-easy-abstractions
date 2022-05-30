using FakeXrmEasy.Abstractions.Plugins;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace FakeXrmEasy.Abstractions
{
    /// <summary>
    /// XrmFakedContext Interface
    /// </summary>
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
        IXrmFakedTracingService GetTracingService();

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
        /// Same as GetEntityById&lt;T&gt; but for late bound entities
        /// </summary>
        /// <param name="logicalName">Logical name of the entity record to retrieve</param>
        /// <param name="id">Primary key of the entity record to retrieve</param>
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

        /// <summary>
        /// PluginContext Properties
        /// </summary>
        IXrmFakedPluginContextProperties PluginContextProperties { get; set; }

        /// <summary>
        /// Add Entity
        /// </summary>
        /// <param name="e"></param>
        void AddEntity(Entity e);

        /// <summary>
        /// Add Entity with defaults
        /// </summary>
        /// <param name="e"></param>
        /// <param name="clone"></param>
        void AddEntityWithDefaults(Entity e, bool clone = false);

        /// <summary>
        /// Create Entity
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        Guid CreateEntity(Entity e);

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="e"></param>
        void UpdateEntity(Entity e);

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="er"></param>
        void DeleteEntity(EntityReference er);

        /// <summary>
        /// Find reflected Type
        /// </summary>
        /// <param name="logicalName"></param>
        /// <returns></returns>
        Type FindReflectedType(string logicalName);

        /// <summary>
        /// Find reflected Attribute Type
        /// </summary>
        /// <param name="earlyBoundType"></param>
        /// <param name="sEntityName"></param>
        /// <param name="attributeName"></param>
        /// <returns></returns>
        Type FindReflectedAttributeType(Type earlyBoundType, string sEntityName, string attributeName);

        /// <summary>
        /// Enable Proxy Types
        /// </summary>
        /// <param name="assembly"></param>
        void EnableProxyTypes(Assembly assembly);

        /// <summary>
        /// Proxy Types Assemblies
        /// </summary>
        IEnumerable<Assembly> ProxyTypesAssemblies { get; }

        /// <summary>
        /// Initialize Metadata from enumeration
        /// </summary>
        /// <param name="entityMetadataList"></param>
        void InitializeMetadata(IEnumerable<EntityMetadata> entityMetadataList);

        /// <summary>
        /// Initialize Metadata from single entity
        /// </summary>
        /// <param name="entityMetadata"></param>
        void InitializeMetadata(EntityMetadata entityMetadata);

        /// <summary>
        /// Initialize Metadata from early-bound assembly
        /// </summary>
        /// <param name="earlyBoundEntitiesAssembly"></param>
        void InitializeMetadata(Assembly earlyBoundEntitiesAssembly);

        /// <summary>
        /// Create Metadata Query
        /// </summary>
        /// <returns></returns>
        IQueryable<EntityMetadata> CreateMetadataQuery();

        /// <summary>
        /// Get Entity Metadata by name
        /// </summary>
        /// <param name="sLogicalName"></param>
        /// <returns></returns>
        EntityMetadata GetEntityMetadataByName(string sLogicalName);

        /// <summary>
        /// Set Entity Metadata
        /// </summary>
        /// <param name="em"></param>
        void SetEntityMetadata(EntityMetadata em);

        /// <summary>
        /// Add Relationship
        /// </summary>
        /// <param name="schemaname"></param>
        /// <param name="relationship"></param>
        void AddRelationship(string schemaname, XrmFakedRelationship relationship);

        /// <summary>
        /// Remove Relationship
        /// </summary>
        /// <param name="schemaname"></param>
        void RemoveRelationship(string schemaname);

        /// <summary>
        /// Get Relationship
        /// </summary>
        /// <param name="schemaName"></param>
        /// <returns></returns>
        XrmFakedRelationship GetRelationship(string schemaName);

        /// <summary>
        /// Relationships
        /// </summary>
        IEnumerable<XrmFakedRelationship> Relationships { get; }

        /// <summary>
        /// Get Record Unique Id (handles alternate keys)
        /// </summary>
        /// <param name="record"></param>
        /// <param name="validate"></param>
        /// <returns></returns>
        Guid GetRecordUniqueId(EntityReference record, bool validate = true);
    }
}