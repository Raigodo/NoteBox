using NoteBox.Application.Dto.Authentication;

namespace NoteBox.Application.Services.Authentication;

public interface IAuthenticationService
{
    Task<AuthenticationResponse> LoginAsync(LoginRequest request);
    Task<AuthenticationResponse> RegisterAsync(RegisterRequest request);
}
