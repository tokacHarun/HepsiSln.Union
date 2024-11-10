using HepsiSln.Application.Exceptions;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HepsiSln.Application
{
    public static class Registiration
    {
        public static void AddApplication(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();
            services.AddTransient<ExceptionMiddleware>();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));
        }
    }
}
