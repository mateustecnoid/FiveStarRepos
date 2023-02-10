using FiveStarRepos.Infra.Data.Network.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Dados.Network.Interfaces
{
    public interface IRepositorioNetwork
    {
        Task<IEnumerable<GitHubApiItensResponse>> GetRepository(string language);
    }
}
