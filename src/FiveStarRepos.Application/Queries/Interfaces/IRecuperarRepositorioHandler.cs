using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Queries.Detalhes;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.Interfaces
{
    public interface IRecuperarRepositorioHandler
    {
        Task<ResultResponse<DetalheRepositorioResponse>> Get(long id);
    }
}
