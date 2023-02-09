using FiveStarRepos.Application.Queries.Interfaces;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.Detalhes
{
    public class DetalheRepositorioHandler : IRecuperarRepositorioHandler
    {
        private readonly IRepositorioRepository _repositorioRepository;

        public DetalheRepositorioHandler(IRepositorioRepository repositorioRepository) => _repositorioRepository = repositorioRepository;

        public async Task<DetalheRepositorioResponse> Get(long id)
        {
            var repositorio = await _repositorioRepository.FindByIdAsync(id);

            if (repositorio is null)
                return null;

            return new DetalheRepositorioResponse(repositorio);
        }
    }
}
