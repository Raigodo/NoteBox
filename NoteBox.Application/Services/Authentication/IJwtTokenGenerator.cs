namespace NoteBox.Application.Services.Authentication;

public interface IJwtTokenGenerator
{
    string GenerateToken(string userId);
}
