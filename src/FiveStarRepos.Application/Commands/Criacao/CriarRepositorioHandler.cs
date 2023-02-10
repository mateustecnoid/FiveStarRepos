using FiveStarRepos.Application.Base;
using FiveStarRepos.Application.Commands.Interfaces;
using FiveStarRepos.Domain;
using FiveStarRepos.Infra.Dados.Helper;
using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveStarRepos.Application.Commands.Criacao
{
    public class CriarRepositorioHandler : ICriarRepositorioHandler
    {
        private readonly IRepositorioNetwork _repositorioNetwork;
        private readonly IRepositorioRepository _repositorioRepository;

        public CriarRepositorioHandler(IRepositorioNetwork repositorioNetwork, IRepositorioRepository repositorioRepository)
        {
            _repositorioNetwork = repositorioNetwork;
            _repositorioRepository = repositorioRepository;
        }

        public async Task<ResultResponse<CriarRepositorioResponse>> Handler()
        {
            var repositorios = new List<Repositorio>(25);

            foreach (var language in AmbienteHelper.Linguagens)
            {
                var resultado = await _repositorioNetwork.GetRepository(language);

                repositorios.AddRange(resultado.Select(response => CriarRepositorioFactory.Build(response)));
            }
                
            if(!repositorios.Any(x => x.IsValid))
            {
               var erros = repositorios.SelectMany(x => x.ValidationResult.Errors.Select(y => y.ErrorMessage)).Distinct();

                return ResultResponse<CriarRepositorioResponse>.BuildFalha(erros);
            }

            await _repositorioRepository.InsertManyAsync(repositorios.ToArray());
            await _repositorioRepository.CommitAsync();

            return ResultResponse<CriarRepositorioResponse>.BuildSucesso();
        }
    }
}
