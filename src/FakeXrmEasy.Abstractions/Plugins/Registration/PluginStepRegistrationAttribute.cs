using FakeXrmEasy.Abstractions.Plugins.Enums;
using System;

namespace FakeXrmEasy.Abstractions.Plugins.Registration
{
    /// <summary>
    /// Provides a method to declare a plugin registration from the plugin class
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PluginStepRegistrationAttribute : Attribute
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public PluginStepRegistrationAttribute()
        {
            Rank = 1;
            Stage = ProcessingStepStage.Postoperation;
            Mode = ProcessingStepMode.Synchronous;
        }

        /// <summary>
        /// Primary key of the stored sdkmessageprocessingstep (Optional)
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Stage where this plugins runs. PostOperation by default
        /// </summary>
        public ProcessingStepStage Stage { get; set; }

        /// <summary>
        /// Name of the OrganizationRequest that triggers this plugin step
        /// </summary>
        public string MessageName { get; set; }

        /// <summary>
        /// Mode of this plugin step (sync or async, sync by default)
        /// </summary>
        public ProcessingStepMode Mode { get; set; }

        /// <summary>
        /// Optional. Entity Logical Name or null, the plugin will only execute for these entities if specified. 
        /// This property will take precedence over EntityTypeCode
        /// </summary>
        public string EntityLogicalName { get; set; }

        /// <summary>
        /// The order in which this plugin will run relative to other plugin steps of the same stage and mode
        /// </summary>
        public int Rank { get; set; }

        /// <summary>
        /// The attributes used to filter the execution of this plugin. The plugin will only execute if any of the attributes are present in the request,
        /// or will run regardless of any attributes if empty
        /// </summary>
        public string[] FilteringAttributes { get; set; }
    }
}
