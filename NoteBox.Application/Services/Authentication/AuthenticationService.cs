using Microsoft.AspNetCore.Identity;
using NoteBox.Application.Dto.Authentication;
using NoteBox.Application.Exceptions.Authentication;
using NoteBox.Domain.Entities;

namespace NoteBox.Application.Services.Authentication;

public class AuthenticationService : IAuthenticationService
{
    private UserManager<User> _userManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public AuthenticationService(
        IJwtTokenGenerator jwtTokenGenerator,
        UserManager<User> userManager)
    {
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
    }

    public async Task<AuthenticationResponse> LoginAsync(LoginRequest request)
    {
        var user = await _userManager.FindByEmailAsync(request.Email);
        if (user == null) 
            throw new IncorrectLoginException();

        var isPasswordCorrect = await _userManager.CheckPasswordAsync(user, request.Password);
        if (isPasswordCorrect)
            return new AuthenticationResponse
            {
                JwtToken = _jwtTokenGenerator.GenerateToken(user.Id)
            };
        else
            throw new IncorrectLoginException();
    }

    public async Task<AuthenticationResponse> RegisterAsync(RegisterRequest request)
    {
        var token = _jwtTokenGenerator.GenerateToken(Guid.NewGuid().ToString());
        return new AuthenticationResponse
        {
            JwtToken = token,
        };
    }
}
