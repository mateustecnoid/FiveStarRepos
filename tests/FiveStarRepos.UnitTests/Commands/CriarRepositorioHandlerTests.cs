using FiveStarRepos.UnitTests.Factories;
using Moq;
using Xunit;

namespace FiveStarRepos.UnitTests.Commands
{
    public class CriarRepositorioHandlerTests
    {
        [Fact]
        public async Task Dado_Resultado_Api_Git_Valido_Quando_CriarRepositorioHandler_Entao_Sucesso()
        {
            var api = RepositorioNetworkFactory.Sample;
            var repository = RepositorioRepositoryFactory.Sample;
            Environment.SetEnvironmentVariable("Linguagens", "csharp");

            var response = GitHubApiItensResponseFactory.SampleLista;

            Mock.Get(api).Setup(x => x.GetRepository(It.IsAny<string>())).ReturnsAsync(response);

            var handler = CriarRepositorioHandlerFactory.CustomSample(api, repository);

            var resultado = await handler.Handler();

            Assert.True(resultado.Sucesso);
            Assert.Null(resultado.Falhas);
        }

        [Fact]
        public async Task Dado_Resultado_Api_Git_Invalido_Quando_CriarRepositorioHandler_Entao_Erro()
        {
            var api = RepositorioNetworkFactory.Sample;
            var repository = RepositorioRepositoryFactory.Sample;
            Environment.SetEnvironmentVariable("Linguagens", "csharp");

            var response = GitHubApiItensResponseFactory.SampleListaInvalido;

            Mock.Get(api).Setup(x => x.GetRepository(It.IsAny<string>())).ReturnsAsync(response);

            var handler = CriarRepositorioHandlerFactory.CustomSample(api, repository);

            var resultado = await handler.Handler();

            Assert.False(resultado.Sucesso);
            Assert.NotEmpty(resultado.Falhas);
        }

        [Fact]
        public async Task Dado_Resultado_Api_Git_Vazio_Quando_CriarRepositorioHandler_Entao_Erro()
        {
            var api = RepositorioNetworkFactory.Sample;
            var repository = RepositorioRepositoryFactory.Sample;
            Environment.SetEnvironmentVariable("Linguagens", "csharp");

            Mock.Get(api).Setup(x => x.GetRepository(It.IsAny<string>())).ReturnsAsync(value: null);

            var handler = CriarRepositorioHandlerFactory.CustomSample(api, repository);

            var resultado = await handler.Handler();

            Assert.False(resultado.Sucesso);
            Assert.NotEmpty(resultado.Falhas);
        }
    }
}
