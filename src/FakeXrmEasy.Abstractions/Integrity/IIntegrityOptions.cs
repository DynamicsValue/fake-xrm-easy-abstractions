namespace FakeXrmEasy.Abstractions.Integrity
{
    /// <summary>
    /// Validate data integrity options
    /// </summary>
    public interface IIntegrityOptions
    {
        /// <summary>
        /// If true, will validate that when adding/updating an entity reference property the associated record will exist
        /// </summary>
        bool ValidateEntityReferences { get; set; }
    }
}
