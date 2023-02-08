using Microsoft.Extensions.DependencyInjection;

namespace FiveStarRepos.Infra.IoC
{
    public static class DependencyResolver
    {
        public static IServiceCollection ConfigureApplicationContext(this IServiceCollection services)
        {

            return services;
        }
    }
}
