namespace NoteBox.Application.Dto.Authentication;

public record RegisterRequest
{
    public string Nickname { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}
