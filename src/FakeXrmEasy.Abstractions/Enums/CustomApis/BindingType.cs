namespace FakeXrmEasy.Abstractions.Enums.CustomApis
{
    /// <summary>
    /// Defines how the action is bound. Use it to restrict custom api to certain Tables (Entities) if needed
    /// </summary>
    public enum BindingType
    {
        /// <summary>
        /// The custom api will execute for any Table
        /// </summary>
        Global = 0,

        /// <summary>
        /// The custom api will execute for a single record of a given Table
        /// </summary>
        Entity = 1,

        /// <summary>
        /// The custom api will execute for a collection of records of a given Table
        /// </summary>
        EntityCollection = 2
    }
}
