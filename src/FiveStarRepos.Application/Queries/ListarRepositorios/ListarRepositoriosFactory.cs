using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Queries.Repositorios;
using FiveStarRepos.Domain;
using System.Collections.Generic;
using System.Linq;

namespace FiveStarRepos.Application.Queries.ListarRepositorios
{
    public static class ListarRepositoriosFactory
    {
        public static PagedResultResponse<ListarRepositoriosResponse> Build(int pagina, int tamanhoPagina, int total, IEnumerable<Repositorio> repositorios)
        {
            var result = repositorios.Select(x => new ListarRepositoriosResponse(x));

            return new PagedResultResponse<ListarRepositoriosResponse>(pagina, tamanhoPagina, total, result);
        }
    }
}
