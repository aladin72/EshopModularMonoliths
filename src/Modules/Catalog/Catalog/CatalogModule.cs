using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped<ICatalogService, CatalogService>();
            return services;
        }


        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Configure middleware for the Catalog module if needed
            return app;
        }

    }
}
