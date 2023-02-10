using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Commands.Criacao;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Commands.Interfaces
{
    public interface ICriarRepositorioHandler
    {
        Task<ResultResponse<CriarRepositorioResponse>> Handler();
    }
}
