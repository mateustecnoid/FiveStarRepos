using FiveStarRepos.Infra.Dados.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Interfaces;
using FiveStarRepos.Infra.Data.Network.Requests;
using FiveStarRepos.Infra.Data.Network.Responses;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Dados.Network
{
    public class RepositorioNetwork : IRepositorioNetwork
    {
        private readonly IGitHubApiNetwork _gitHubNetwork;

        public RepositorioNetwork(IGitHubApiNetwork gitHubNetwork) => _gitHubNetwork = gitHubNetwork;

        public async Task<IEnumerable<GitHubApiItensResponse>> GetRepository(string language)
        {
            var request = new GitHubApiRequest()
            {
                Query = $"language:{language}"
            };

            var response = await _gitHubNetwork.Get(request);

            if (response.IsSuccessStatusCode)
                return response.Content.Items;

            return null;
        }
    }
}
