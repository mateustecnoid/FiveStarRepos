using FiveStarRepos.Application.Queries.Base;
using FiveStarRepos.Application.Queries.Repositorios;
using FiveStarRepos.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FiveStarRepos.Application.Queries.ListarRepositorios
{
    public static class ListarRepositoriosFactory
    {
        public static PagedResultResponse<ListarRepositoriosResponse> Build(int page, int pageSize, int total, IEnumerable<Repositorio> repositorios)
        {
            var result = repositorios.Select(x => new ListarRepositoriosResponse(x));

            return new PagedResultResponse<ListarRepositoriosResponse>(page, pageSize, total, result);
        }
    }
}
