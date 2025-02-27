using Microsoft.EntityFrameworkCore;
using ProductTrackingProject.Persistence.Contexts;
namespace ProductTrackingProject.Presentation.Extensions;
public static class ServiceRegistration
{
    public static IServiceCollection AddPresentationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        return services;
    }
}