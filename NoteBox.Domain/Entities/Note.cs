using NoteBox.Domain.Entities.Primitives;

namespace NoteBox.Domain.Entities;

public sealed class Note : Entity
{
    public required string Title { get; set; }
    public string Description { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;

    public required string CreatorId { get; set; }
    public bool IsActive { get; set; } = true;

    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime? EditedAt { get; set; } = null;
}
