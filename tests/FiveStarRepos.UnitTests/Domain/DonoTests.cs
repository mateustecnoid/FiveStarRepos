using FiveStarRepos.UnitTests.Factories;
using Xunit;

namespace FiveStarRepos.UnitTests.Domain
{
    public class DonoTests
    {
        [Fact]
        public void Dado_Dono_Valido_Quando_Validar_Entao_Sucesso()
        {
            var dono = DonoFactory.Dono;

            Assert.NotNull(dono);
            Assert.True(dono.IsValid);
            Assert.Empty(dono.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Dono_Invalido_Com_Login_Vazio_Quando_Validar_Entao_Erro()
        {
            var dono = DonoFactory.DonoComLoginVazio;

            Assert.NotNull(dono);
            Assert.False(dono.IsValid);
            Assert.NotEmpty(dono.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Dono_Invalido_Com_Tamanho_Excedido_Login_Quando_Validar_Entao_Erro()
        {
            var dono = DonoFactory.DonoComTamanhoLoginExcedido;

            Assert.NotNull(dono);
            Assert.False(dono.IsValid);
            Assert.NotEmpty(dono.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Dono_Invalido_Com_Url_Vazio_Quando_Validar_Entao_Erro()
        {
            var dono = DonoFactory.DonoComUrlInvalida;

            Assert.NotNull(dono);
            Assert.False(dono.IsValid);
            Assert.NotEmpty(dono.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Dono_Invalido_Com_AvatarUrl_Vazio_Quando_Validar_Entao_Erro()
        {
            var dono = DonoFactory.DonoComAvatarUrlInvalida;

            Assert.NotNull(dono);
            Assert.False(dono.IsValid);
            Assert.NotEmpty(dono.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Dono_Invalido_Com_Tipo_Vazio_Quando_Validar_Entao_Erro()
        {
            var dono = DonoFactory.DonoComTipoVazio;

            Assert.NotNull(dono);
            Assert.False(dono.IsValid);
            Assert.NotEmpty(dono.ValidationResult.Errors);
        }

        [Fact]
        public void Dado_Dono_Invalido_Com_Tamanho_Excedido_Tipo_Quando_Validar_Entao_Erro()
        {
            var dono = DonoFactory.DonoComTamanhoTipoExcedido;

            Assert.NotNull(dono);
            Assert.False(dono.IsValid);
            Assert.NotEmpty(dono.ValidationResult.Errors);
        }
    }
}
