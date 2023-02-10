using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using Moq;

namespace FiveStarRepos.UnitTests.Factories
{
    public static class RepositorioRepositoryFactory
    {
        public static IRepositorioRepository Sample => Mock.Of<IRepositorioRepository>();
    }
}
