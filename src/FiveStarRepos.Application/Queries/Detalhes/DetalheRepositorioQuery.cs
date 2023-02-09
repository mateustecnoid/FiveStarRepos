using FiveStarRepos.Application.Queries.Interfaces;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.Detalhes
{
    public class DetalheRepositorioQuery : IRecuperarRepositorioQuery
    {
        private readonly IRepositorioRepository _repositorioRepository;

        public DetalheRepositorioQuery(IRepositorioRepository repositorioRepository) => _repositorioRepository = repositorioRepository;

        public async Task<DetalheRepositorioResponse> Get(long id)
        {
            var repositorio = await _repositorioRepository.FindByIdAsync(id);

            if (repositorio is null)
                return null;

            return new DetalheRepositorioResponse(repositorio);
        }
    }
}
