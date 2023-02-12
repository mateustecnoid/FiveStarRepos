using FiveStarRepos.Application.Commands.Criacao;
using FiveStarRepos.Application.Commands.Interfaces;
using FiveStarRepos.Application.Queries.Detalhes;
using FiveStarRepos.Application.Queries.Interfaces;
using FiveStarRepos.Application.Queries.ListarRepositorios;
using FiveStarRepos.Infra.Dados.Network;
using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Interfaces;
using FiveStarRepos.Infra.Data.Repositories;
using FiveStarRepos.Infra.Data.Repositories.Contexts;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using FiveStarRepos.Infra.IoC.Configuration;
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
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                    sqlOptions =>
                    {
                        sqlOptions.MigrationsAssembly("FiveStarRepos.Infra.Dados");
                    });
            });

            services.AddScoped<FiveStarReposContext>();
            services.AddScoped<IRepositorioRepository, RepositorioRepository>();

            services.AddScoped<IRepositorioNetwork, RepositorioNetwork>();

            services.AddScoped<ICriarRepositorioHandler, CriarRepositorioHandler>();
            services.AddScoped<IRecuperarRepositorioHandler, DetalheRepositorioHandler>();
            services.AddScoped<IListarRepositoriosHandler, ListarRepositoriosHandler>();


            services.AddRefit<IGitHubApiNetwork>(AppConstants.ApiGitHub, configuration)
                    .UseConfigHeaders(AppConstants.ApiGitHub, configuration)
                    .AddRetryPolicy(configuration);

            return services;
        }
    }
}
