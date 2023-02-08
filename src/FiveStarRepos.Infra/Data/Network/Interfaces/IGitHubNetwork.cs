using FiveStarRepos.Infra.Data.Network.Requests;
using FiveStarRepos.Infra.Data.Network.Responses;
using Refit;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Network.Interfaces
{
    public interface IGitHubNetwork
    {
        [Get("/search/repositories")]
        public Task<ApiResponse<TopFiveReposResponse>> Get([Query] TopFiveReposRequest request);
    }
}
