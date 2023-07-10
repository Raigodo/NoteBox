using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NoteBox.Application.Services.Authentication;

namespace NoteBox.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.SectionName));

        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        return services;
    }
}
