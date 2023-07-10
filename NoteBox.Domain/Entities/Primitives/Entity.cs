using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace NoteBox.Domain.Entities.Primitives;

public abstract class Entity
{
    [Key]
    public required string Id { get; set; }


    public override bool Equals([AllowNull] object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        return Id == ((Entity)obj).Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }

    public static bool operator ==(Entity? entity1, Entity? entity2)
    {
        if (entity1 == null || entity2 == null)
            return false;

        return entity1.Id == entity2.Id;
    }
    public static bool operator !=(Entity? entity1, Entity? entity2)
    {
        return !(entity1 == entity2);
    }
}
