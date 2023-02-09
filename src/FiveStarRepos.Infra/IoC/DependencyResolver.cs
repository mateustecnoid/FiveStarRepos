using FiveStarRepos.Infra.Data.Network.Interfaces;
using FiveStarRepos.Infra.Data.Repositories;
using FiveStarRepos.Infra.Data.Repositories.Contexts;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using FiveStarRepos.Infra.Helper;
using FiveStarRepos.Infra.IoC.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FiveStarRepos.Infra.IoC
{
    public static class DependencyResolver
    {
        public static IServiceCollection ConfigureApplicationContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FiveStarReposContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddScoped<FiveStarReposContext>();
            services.AddScoped<IRepositorioRepository, RepositorioRepository>();

            services.AddRefit<IGitHubNetwork>(AppConstants.ApiGitHub, configuration)
                    .UseConfigHeaders(AppConstants.ApiGitHub, configuration)
                    .AddRetryPolicy(configuration);

            return services;
        }
    }
}
