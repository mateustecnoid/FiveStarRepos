using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Queries.Interfaces;
using FiveStarRepos.Application.Queries.Repositorios;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.ListarRepositorios
{
    public class ListarRepositoriosHandler : IListarRepositoriosHandler
    {
        private readonly IRepositorioRepository _repositorioRepository;

        public ListarRepositoriosHandler(IRepositorioRepository repositorioRepository) => _repositorioRepository = repositorioRepository;

        public async Task<PagedResultResponse<ListarRepositoriosResponse>> SearchAsync(ListarRepositoriosQuery query)
        {
            var repositorios = await _repositorioRepository.SearchAsync(query.Pagina, query.TamanhoPagina);
            var total = await _repositorioRepository.CountAsync();

            if (repositorios is null)
                return null;

            return ListarRepositoriosFactory.Build(query.Pagina, query.TamanhoPagina, total, repositorios);
        }
    }
}
