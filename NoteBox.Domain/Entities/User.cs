using Microsoft.AspNetCore.Identity;

namespace NoteBox.Domain.Entities;

public sealed class User : IdentityUser
{
    public bool IsActive { get; set; }
    public required string Nickname { get; set; }
    public string AvatarImgUrl { get; set; } = ""; //TODO add default image
    public string AboutMe { get; set; } = "";
    public required DateTime LastSeenAt { get; set; }
}
