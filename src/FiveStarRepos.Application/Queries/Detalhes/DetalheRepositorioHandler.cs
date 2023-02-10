using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Queries.Interfaces;
using FiveStarRepos.Domain.Resources;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Queries.Detalhes
{
    public class DetalheRepositorioHandler : IRecuperarRepositorioHandler
    {
        private readonly IRepositorioRepository _repositorioRepository;

        public DetalheRepositorioHandler(IRepositorioRepository repositorioRepository) => _repositorioRepository = repositorioRepository;

        public async Task<ResultResponse<DetalheRepositorioResponse>> Get(long id)
        {
            var repositorio = await _repositorioRepository.FindByIdAsync(id);

            if (repositorio is null)
                return ResultResponse<DetalheRepositorioResponse>.BuildFalha(MensagemResource.RegistroNaoEncontrado);

            return ResultResponse<DetalheRepositorioResponse>.BuildSucesso(new DetalheRepositorioResponse(repositorio));
        }
    }
}
