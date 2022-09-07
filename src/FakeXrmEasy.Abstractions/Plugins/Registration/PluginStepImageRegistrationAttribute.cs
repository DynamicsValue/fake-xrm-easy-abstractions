using FakeXrmEasy.Abstractions.Plugins.Enums;
using System;
using System.Collections.Generic;

namespace FakeXrmEasy.Abstractions.Plugins.Registration
{
    /// <summary>
    /// Attribute to register an image definition for a given plugin step
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class PluginStepImageRegistrationAttribute : Attribute
    {
        /// <summary>
        /// Primary key of the associated plugin step to which this image belongs
        /// </summary>
        public string StepId { get; set; }

        /// <summary>
        /// Name of the plugin image definition
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of Image: PreImage, PostImage, or Both
        /// </summary>
        public ProcessingStepImageType ImageType { get; set; }

        /// <summary>
        /// Attributes that this plugin image contains
        /// </summary>
        public string[] Attributes { get; set; }
    }
}
