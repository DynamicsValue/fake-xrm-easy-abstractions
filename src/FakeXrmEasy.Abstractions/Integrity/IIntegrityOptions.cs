namespace FakeXrmEasy.Abstractions.Integrity
{
    public interface IIntegrityOptions
    {
        //If true, will validate that when adding / updating an entity reference property the associated record will exist
        bool ValidateEntityReferences { get; set; }
    }
}
