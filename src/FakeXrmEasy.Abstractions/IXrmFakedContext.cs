using Microsoft.Xrm.Sdk;
using System;
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

        /// <summary>
        /// Returns a faked plugin that will be executed against this faked context and the entity passed as the target
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPlugin ExecutePluginWithTarget<T>(Entity target, string messageName = "Create", int stage = 40)
            where T : IPlugin, new();

        /// <summary>
        /// Returns a faked plugin that will be executed against this faked context and the entity passed as the target
        /// </summary>
        /// <returns></returns>
        IPlugin ExecutePluginWithTarget(IPlugin instance, Entity target, string messageName = "Create", int stage = 40);

        /// <summary>
        /// Returns a faked plugin that will be executed against this faked context and the entity passed as the target
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPlugin ExecutePluginWithTargetReference<T>(EntityReference target, string messageName = "Create", int stage = 40)
            where T : IPlugin, new();

        /// <summary>
        /// Returns a faked plugin that will be executed against this faked context and the entity passed as the target
        /// </summary>
        /// <returns></returns>
        IPlugin ExecutePluginWithTargetReference(IPlugin instance, EntityReference target, string messageName = "Create", int stage = 40);

        /// <summary>
        /// Returns a faked plugin with a target and the specified pre entity images
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Obsolete]
        IPlugin ExecutePluginWithTargetAndPreEntityImages<T>(object target, EntityImageCollection preEntityImages, string messageName = "Create", int stage = 40)
            where T : IPlugin, new();

        /// <summary>
        /// Returns a faked plugin with a target and the specified post entity images
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        [Obsolete]
        IPlugin ExecutePluginWithTargetAndPostEntityImages<T>(object target, EntityImageCollection postEntityImages, string messageName = "Create", int stage = 40)
            where T : IPlugin, new();

        /// <summary>
        /// Execute a plugin with input and output params, as well as entity images
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IPlugin ExecutePluginWith<T>(ParameterCollection inputParameters, ParameterCollection outputParameters, EntityImageCollection preEntityImages, EntityImageCollection postEntityImages)
            where T : IPlugin, new();

        /// <summary>
        /// Returns a plugin context with default properties one can override
        /// </summary>
        /// <returns></returns>
        IPluginExecutionContext GetDefaultPluginContext();

        /// <summary>
        /// Executes a plugin passing a custom context. This is useful whenever we need to mock more complex plugin contexts (ex: passing MessageName, plugin Depth, InitiatingUserId etc...)
        /// </summary>
        /// <typeparam name="T">Must be a plugin</typeparam>
        /// <param name="ctx"></param>
        /// <returns></returns>
        IPlugin ExecutePluginWith<T>(IPluginExecutionContext ctx)
            where T : IPlugin, new();

        /// <summary>
        /// Executes a plugin passing a custom context. This is useful whenever we need to mock more complex plugin contexts (ex: passing MessageName, plugin Depth, InitiatingUserId etc...)
        /// </summary>
        /// <param name="ctx"></param>
        /// <param name="instance"></param>
        /// <returns></returns>
        IPlugin ExecutePluginWith(IPluginExecutionContext ctx, IPlugin instance);

        /// <summary>
        /// Executes a plugin with a custom context and custom configurations (configurations aren't inherent properties of the context so they need to be passed separately)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="plugCtx"></param>
        /// <param name="unsecureConfiguration"></param>
        /// <param name="secureConfiguration"></param>
        /// <returns></returns>
        IPlugin ExecutePluginWithConfigurations<T>(IPluginExecutionContext plugCtx,
                                     string unsecureConfiguration,
                                     string secureConfiguration)
            where T : class, IPlugin;

        [Obsolete("Use ExecutePluginWith(XrmFakedPluginExecutionContext ctx, IPlugin instance).")]
        IPlugin ExecutePluginWithConfigurations<T>(IPluginExecutionContext plugCtx, T instance, string unsecureConfiguration, string secureConfiguration)
            where T : class, IPlugin;
    }
}