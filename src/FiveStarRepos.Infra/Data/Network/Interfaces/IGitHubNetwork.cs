using FiveStarRepos.Infra.Data.Network.Requests;
using Refit;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Network.Interfaces
{
    public interface IGitHubNetwork
    {
        [Get("/search/repositories")]
        public Task<ApiResponse<string>> Get([Query] TopFiveReposRequest request);
    }
}
