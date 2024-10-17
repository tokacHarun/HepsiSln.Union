using HepsiSln.Application.Interfaces.Repostories;
using HepsiSln.Persistence.Context;
using HepsiSln.Persistence.Repostories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace HepsiSln.Persistence
{
    public static class Registration
    {
        public static void AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(opt =>
            opt.UseSqlServer(configuration.GetConnectionString("DefaulConnection")));

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
        }
    }
}
