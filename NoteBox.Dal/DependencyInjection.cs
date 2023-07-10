using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace NoteBox.Dal;

public static class DependencyInjection
{
    public static IServiceCollection AddDal(this IServiceCollection services)
    {
        services.AddDbContext<ApiDbContext>(options => options.UseInMemoryDatabase("NoteBoxDatabase"));
        return services;
    }
}
