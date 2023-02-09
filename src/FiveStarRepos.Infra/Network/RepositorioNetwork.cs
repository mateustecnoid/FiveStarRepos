using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Requests;
using FiveStarRepos.Infra.Data.Network.Responses;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Dados.Network
{
    public class RepositorioNetwork : IRepositorioNetwork
    {
        private readonly IGitHubNetwork _gitHubNetwork;

        public RepositorioNetwork(IGitHubNetwork gitHubNetwork) => _gitHubNetwork = gitHubNetwork;

        public async Task<TopFiveReposResponse> GetRepository(string language)
        {
            var request = new TopFiveReposRequest()
            {
                Query = $"language:{language}"
            };

            var response = await _gitHubNetwork.Get(request);

            if (response.IsSuccessStatusCode)
                return response.Content;

            return null;
        }
    }
}
