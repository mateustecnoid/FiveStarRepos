using FiveStarRepos.UnitTests.Factories;
using Xunit;

namespace FiveStarRepos.UnitTests.Domain
{
    public class RepositorioTests
    {
        [Fact]
        public void Dado_Repositorio_Valido_Quando_Validar_Entao_Sucesso()
        {
            var repositorio = RepositorioFactory.Repositorio;

            Assert.NotNull(repositorio);
            Assert.True(repositorio.IsValid);
            Assert.Empty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Nome_Vazio_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComNomeVazio;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Tamanho_Nome_Excedido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComTamanhoNomeExcedido;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_NomeCompleto_Vazio_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComNomeCompletoVazio;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Tamanho_NomeCompleto_Excedido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComTamanhoNomeCompletoExcedido;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Url_Vazio_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComUriVazio;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Descricao_Vazio_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComDescricaoVazio;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Tamanho_Descricao_Excedido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComTamanhoDescricaoExcedido;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_DataCriacao_Invalida_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComDataCriacaoInvalida;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_DataAtualizacao_Invalida_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComDataAtualizacaoInvalida;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Tamanho_Invalido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComTamanhoInvalido;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Stars_Invalido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComStarsInvalida;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Linguagem_Invalido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComLinguagemInvalida;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_Tamanho_Linguagem_Excedido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComTamanhoLinguagemExcedido;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_BranchPadrao_Invalido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComBranchPadraoInvalida;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Repositorio_Invalido_Com_BranchPadrao_Linguagem_Excedido_Quando_Validar_Entao_Erro()
        {
            var repositorio = RepositorioFactory.RepositorioComTamanhoBranchPadraoExcedido;

            Assert.NotNull(repositorio);
            Assert.False(repositorio.IsValid);
            Assert.NotEmpty(repositorio.ValidationResult.Errors);
        }
    }
}
