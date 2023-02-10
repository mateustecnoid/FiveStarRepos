using FiveStarRepos.UnitTests.Factories;
using Xunit;

namespace FiveStarRepos.UnitTests.Domain
{
    public class LicencaTests
    {
        [Fact]
        public void Dado_Licenca_Valida_Quando_Validar_Entao_Sucesso()
        {
            var licenca = LicencaFactory.Licenca;

            Assert.NotNull(licenca);
            Assert.True(licenca.IsValid);
            Assert.Empty(licenca.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Licenca_Invalida_Com_Chave_Vazia_Entao_Erro()
        {
            var licenca = LicencaFactory.LicencaComChaveVazio;

            Assert.NotNull(licenca);
            Assert.False(licenca.IsValid);
            Assert.NotEmpty(licenca.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Licenca_Invalida_Com_Chave_Tamanho_Excedido_Entao_Erro()
        {
            var licenca = LicencaFactory.LicencaComTamanhoChaveExcedido;

            Assert.NotNull(licenca);
            Assert.False(licenca.IsValid);
            Assert.NotEmpty(licenca.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Licenca_Invalida_Com_Nome_Vazio_Entao_Erro()
        {
            var licenca = LicencaFactory.LicencaComNomeVazio;

            Assert.NotNull(licenca);
            Assert.False(licenca.IsValid);
            Assert.NotEmpty(licenca.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Licenca_Invalida_Com_Nome_Tamanho_Excedido_Entao_Erro()
        {
            var licenca = LicencaFactory.LicencaComTamanhoNomeExcedido;

            Assert.NotNull(licenca);
            Assert.False(licenca.IsValid);
            Assert.NotEmpty(licenca.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Licenca_Invalida_Com_Url_Invalido_Entao_Erro()
        {
            var licenca = LicencaFactory.LicencaComUrlVazia;

            Assert.NotNull(licenca);
            Assert.False(licenca.IsValid);
            Assert.NotEmpty(licenca.ValidationResult.Errors);
        }
    }
}
