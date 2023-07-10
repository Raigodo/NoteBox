namespace NoteBox.Application.Dto.Authentication;

public record AuthenticationResponse
{
    public required string JwtToken = null!;
}
