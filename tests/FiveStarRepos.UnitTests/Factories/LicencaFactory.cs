using FiveStarRepos.Domain;
using FiveStarRepos.UnitTests.Util;

namespace FiveStarRepos.UnitTests.Factories
{
    public class LicencaFactory
    {
        public static Licenca Licenca => new
            (
                chave: "mit",
                nome: "MIT License",
                url: new Uri("https://api.github.com/licenses/mit")
            );

        public static Licenca LicencaComChaveVazio => new
            (
                chave: string.Empty,
                nome: "MIT License",
                url: new Uri("https://api.github.com/licenses/mit")
            );

        public static Licenca LicencaComTamanhoChaveExcedido => new
            (
                chave: FactoryUtil.RandomString(51),
                nome: "MIT License",
                url: new Uri("https://api.github.com/licenses/mit")
            );

        public static Licenca LicencaComNomeVazio => new
            (
                chave: "mit",
                nome: string.Empty,
                url: new Uri("https://api.github.com/licenses/mit")
            );

        public static Licenca LicencaComTamanhoNomeExcedido => new
            (
                chave: "mit",
                nome: FactoryUtil.RandomString(51),
                url: new Uri("https://api.github.com/licenses/mit")
            );
    }
}
