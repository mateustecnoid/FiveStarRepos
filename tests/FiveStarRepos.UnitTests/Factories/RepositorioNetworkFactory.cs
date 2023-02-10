using FiveStarRepos.Infra.Dados.Network.Interfaces;
using Moq;

namespace FiveStarRepos.UnitTests.Factories
{
    public static class RepositorioNetworkFactory
    {
        public static IRepositorioNetwork Sample => Mock.Of<IRepositorioNetwork>();
    }
}
