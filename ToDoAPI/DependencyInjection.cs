using Microsoft.EntityFrameworkCore;

namespace ToDoAPI
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {

            var connectionstring = configuration.GetConnectionString("DatabaseConnection");

            services.AddDbContext<ToDoDbContext>(options =>
            {
                options.UseSqlServer(connectionstring);
            }
            );

            return services;
        }
    }
    
}
