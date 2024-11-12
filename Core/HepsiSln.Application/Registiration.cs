using FluentValidation;
using HepsiSln.Application.Behaviors;
using HepsiSln.Application.Exceptions;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;
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

            services.AddValidatorsFromAssembly(assembly);
            ValidatorOptions.Global.LanguageManager.Culture = new CultureInfo("tr");
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(FluentValidationBehavior<,>));
        }
    }
}
