using FiveStarRepos.Application.Queries.Detalhes;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.Interfaces
{
    public interface IRecuperarRepositorioHandler
    {
        Task<DetalheRepositorioResponse> Get(long id);
    }
}
