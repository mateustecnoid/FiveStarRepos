using FiveStarRepos.Application.Commands.Criacao;
using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;

namespace FiveStarRepos.UnitTests.Factories
{
    public static class CriarRepositorioHandlerFactory
    {
        public static CriarRepositorioHandler Sample => new(RepositorioNetworkFactory.Sample, RepositorioRepositoryFactory.Sample);

        public static CriarRepositorioHandler CustomSample(IRepositorioNetwork repositorioNetwork, IRepositorioRepository repositorioRepository) => new
            (
                repositorioNetwork ?? RepositorioNetworkFactory.Sample,
                repositorioRepository ?? RepositorioRepositoryFactory.Sample
            );
    }
}
