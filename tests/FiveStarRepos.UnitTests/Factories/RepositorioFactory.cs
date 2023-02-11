using FiveStarRepos.Domain;
using FiveStarRepos.UnitTests.Util;

namespace FiveStarRepos.UnitTests.Factories
{
    public static class RepositorioFactory
    {
        public static Repositorio Repositorio => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComNomeVazio => new
            (
                nome: string.Empty,
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComTamanhoNomeExcedido => new
            (
                nome: FactoryUtil.RandomString(51),
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComNomeCompletoVazio => new
           (
               nome: "Repositorio 001",
               nomeCompleto: string.Empty,
               privado: false,
               url: new Uri("https://github.com/"),
               descricao: "Descricao do repositorio 001",
               dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
               dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
               tamanho: 1000,
               stars: 2000,
               linguagem: "C#",
               branchPadrao: "master",
               dono: null,
               licenca: null
           );

        public static Repositorio RepositorioComTamanhoNomeCompletoExcedido => new
           (
               nome: "Repositorio 001",
               nomeCompleto: FactoryUtil.RandomString(151),
               privado: false,
               url: new Uri("https://github.com/"),
               descricao: "Descricao do repositorio 001",
               dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
               dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
               tamanho: 1000,
               stars: 2000,
               linguagem: "C#",
               branchPadrao: "master",
               dono: null,
               licenca: null
           );

        public static Repositorio RepositorioComUriVazio => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: null,
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComTamanhoDescricaoExcedido => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: FactoryUtil.RandomString(501),
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComDataCriacaoInvalida => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: new DateTime(),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComDataAtualizacaoInvalida => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: new DateTime(),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComTamanhoInvalido => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 0,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComStarsInvalida => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 0,
                linguagem: "C#",
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComLinguagemInvalida => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: string.Empty,
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComTamanhoLinguagemExcedido => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: FactoryUtil.RandomString(51),
                branchPadrao: "master",
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComBranchPadraoInvalida => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: string.Empty,
                dono: null,
                licenca: null
            );

        public static Repositorio RepositorioComTamanhoBranchPadraoExcedido => new
            (
                nome: "Repositorio 001",
                nomeCompleto: "Nome completo do repositorio 001",
                privado: false,
                url: new Uri("https://github.com/"),
                descricao: "Descricao do repositorio 001",
                dataCriacaoRepositorio: DateTime.UtcNow.AddDays(-10),
                dataAtualizacaoRepositorio: DateTime.UtcNow.AddDays(-1),
                tamanho: 1000,
                stars: 2000,
                linguagem: "C#",
                branchPadrao: FactoryUtil.RandomString(51),
                dono: null,
                licenca: null
            );
    }
}
