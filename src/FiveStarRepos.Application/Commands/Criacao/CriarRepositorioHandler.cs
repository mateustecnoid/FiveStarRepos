using FiveStarRepos.Application.Commands.Interfaces;
using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using System.Linq;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Commands.Criacao
{
    public class CriarRepositorioHandler : ICriarRepositorioHandler
    {
        private readonly IRepositorioNetwork _repositorioNetwork;
        private readonly IRepositorioRepository _repositorioRepository;
        private readonly string[] languages = { "csharp", "javascript", "go", "python", "javascript" };

        public CriarRepositorioHandler(IRepositorioNetwork repositorioNetwork, IRepositorioRepository repositorioRepository)
        {
            _repositorioNetwork = repositorioNetwork;
            _repositorioRepository = repositorioRepository;
        }

        public async Task Handler()
        {
            foreach (var language in languages)
            {
                var result = await _repositorioNetwork.GetRepository(language);

                var respositorios = CriarRepositorioFactory.Build(result);

                await _repositorioRepository.InsertManyAsync(respositorios.ToArray());
                await _repositorioRepository.CommitAsync();
            }
        }
    }
}
