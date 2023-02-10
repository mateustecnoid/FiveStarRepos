using FiveStarRepos.Domain;
using FiveStarRepos.Infra.Data.Network.Responses;

namespace FiveStarRepos.Application.Commands.Criacao
{
    public static class CriarRepositorioFactory
    {
        public static Repositorio Build(GitHubApiItensResponse response)
        {
            if (response is null) return null;

            Dono dono = response.Owner is not null ? new(response.Owner.Login, response.Owner.HtmlUrl, response.Owner.AvatarUrl, response.Owner.Type) : null;

            Licenca licenca = response.License is not null ? new Licenca(response.License.Key, response.License.Name, response.License.Url) : null;

            var repositorio = new Repositorio(response.Name, response.FullName, response.Private, response.HtmlUrl, response.Description, response.CreatedAt,
                                              response.UpdatedAt, response.Size, response.StargazersCount, response.Language, response.DefaultBranch, dono, licenca);


            return repositorio;
        }
    }
}
