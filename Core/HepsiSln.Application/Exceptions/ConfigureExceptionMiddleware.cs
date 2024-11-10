using Microsoft.AspNetCore.Builder;

namespace HepsiSln.Application.Exceptions
{
    public static class ConfigureExceptionMiddleware
    {
     public static void ConfigureExceptionHandlingMiddleware(this IApplicationBuilder app) 
        { 
            app.UseMiddleware<ExceptionMiddleware>();
        }  
    }
}
