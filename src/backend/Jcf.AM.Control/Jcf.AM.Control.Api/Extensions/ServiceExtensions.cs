using Jcf.AM.Control.Api.Services;
using Jcf.AM.Control.Api.Services.IServices;

namespace Jcf.AM.Control.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IAuthService, AuthService>();
            //services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
