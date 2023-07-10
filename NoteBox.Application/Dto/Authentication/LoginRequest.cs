using System.ComponentModel.DataAnnotations;

namespace NoteBox.Application.Dto.Authentication;

public record LoginRequest
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
