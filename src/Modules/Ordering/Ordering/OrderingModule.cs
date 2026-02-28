

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ordering
{
    public static class OrderingModule
    {
        public static IServiceCollection AddOrderingModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<IOrderingService, OrderingService>();
            return services;
        }

        public static IApplicationBuilder UseOrderingModule(this IApplicationBuilder app)
        {
            // Configure middleware for the Catalog module if needed
            return app;
        }
    }
}
