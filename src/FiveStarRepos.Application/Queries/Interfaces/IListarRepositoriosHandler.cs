using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Queries.ListarRepositorios;
using FiveStarRepos.Application.Queries.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.Interfaces
{
    public interface IListarRepositoriosHandler
    {
        Task<PagedResultResponse<ListarRepositoriosResponse>> SearchAsync(ListarRepositoriosQuery query);
    }
}
