

using Xunit;

namespace FakeXrmEasy.Abstractions.Tests
{
    public class XrmFakedRelationshipTests
    {
        [Fact]
        public void Should_create_a_many_to_many_relationship_by_default()
        {
            var relationship = new XrmFakedRelationship();
            Assert.Equal(XrmFakedRelationship.FakeRelationshipType.ManyToMany, relationship.RelationshipType);
        }

        [Fact]
        public void Should_create_a_one_to_many_relationship_when_not_passing_in_the_intersect_entity_name()
        {
            var relationship = 
                new XrmFakedRelationship("attribute1","attribute2","entity1", "entity2");

            Assert.Equal("attribute1", relationship.Entity1Attribute);
            Assert.Equal("attribute2", relationship.Entity2Attribute); 
            Assert.Equal("entity1", relationship.Entity1LogicalName); 
            Assert.Equal("entity2", relationship.Entity2LogicalName);     
            Assert.Equal(XrmFakedRelationship.FakeRelationshipType.OneToMany, relationship.RelationshipType);
        }

        [Fact]
        public void Should_create_a_many_to_many_relationship_when_passing_in_the_intersect_entity_name()
        {
            var relationship = 
                new XrmFakedRelationship("intersect", "attribute1","attribute2","entity1", "entity2");

            Assert.Equal("attribute1", relationship.Entity1Attribute);
            Assert.Equal("attribute2", relationship.Entity2Attribute); 
            Assert.Equal("entity1", relationship.Entity1LogicalName); 
            Assert.Equal("entity2", relationship.Entity2LogicalName);
            Assert.Equal("intersect", relationship.IntersectEntity);     
            Assert.Equal(XrmFakedRelationship.FakeRelationshipType.ManyToMany, relationship.RelationshipType);
        }

        [Fact]
        public void Should_append_an_extra_alias_in_a_self_referential_relationship()
        {
            var relationship = 
                new XrmFakedRelationship("intersect", "attribute1","attribute1","entity1", "entity1");

            Assert.Equal("attribute1one", relationship.Entity1Attribute);
            Assert.Equal("attribute1two", relationship.Entity2Attribute); 
            Assert.Equal("entity1", relationship.Entity1LogicalName); 
            Assert.Equal("entity1", relationship.Entity2LogicalName);
            Assert.Equal("intersect", relationship.IntersectEntity);     
            Assert.Equal(XrmFakedRelationship.FakeRelationshipType.ManyToMany, relationship.RelationshipType);
        }
    }
}
