using FiveStarRepos.Domain;
using FiveStarRepos.UnitTests.Util;

namespace FiveStarRepos.UnitTests.Factories
{
    public static class DonoFactory
    {
        public static Dono Dono => new
            (
                login: "microsoft",
                url: new Uri("https://github.com/microsoft"),
                avatarUrl: new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                tipo: "Organization"
            );

        public static Dono DonoComLoginVazio => new
            (
                login: string.Empty,
                url: new Uri("https://github.com/microsoft"),
                avatarUrl: new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                tipo: "Organization"
            );

        public static Dono DonoComTamanhoLoginExcedido => new
            (
                login: FactoryUtil.RandomString(101),
                url: new Uri("https://github.com/microsoft"),
                avatarUrl: new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                tipo: "Organization"
            );

        public static Dono DonoComUrlInvalida => new
            (
                login: "microsoft",
                url: null,
                avatarUrl: new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                tipo: "Organization"
            );

        public static Dono DonoComAvatarUrlInvalida => new
            (
                login: "microsoft",
                url: new Uri("https://github.com/microsoft"),
                avatarUrl: null,
                tipo: "Organization"
            );

        public static Dono DonoComTipoVazio => new
            (
                login: "microsoft",
                url: new Uri("https://github.com/microsoft"),
                avatarUrl: new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                tipo: string.Empty
            );

        public static Dono DonoComTamanhoTipoExcedido => new
            (
                login: "microsoft",
                url: new Uri("https://github.com/microsoft"),
                avatarUrl: new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                tipo: FactoryUtil.RandomString(101)
            );
    }
}
