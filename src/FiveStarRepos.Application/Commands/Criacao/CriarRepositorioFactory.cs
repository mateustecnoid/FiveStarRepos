using FiveStarRepos.Domain;
using FiveStarRepos.Infra.Data.Network.Responses;
using System.Collections.Generic;
using System.Linq;

namespace FiveStarRepos.Application.Commands.Criacao
{
    public static class CriarRepositorioFactory
    {
        public static IEnumerable<Repositorio> Build(GitHubApiResponse response)
        {
            if (response is null || !response.Items.Any()) return null;

            IList<Repositorio> repositorios = new List<Repositorio>(5);

            foreach (var item in response.Items)
            {
                var dono = new Dono(item.Owner.Login, item.Owner.HtmlUrl, item.Owner.AvatarUrl, item.Owner.Type);

                Licenca licenca = item.License is not null ? new Licenca(item.License.Key, item.License.Name, item.License.Url) : null;

                var repositorio = new Repositorio(item.Name, item.FullName, item.Private, item.HtmlUrl, item.Description, item.CreatedAt,
                                                  item.UpdatedAt, item.Size, item.StargazersCount, item.Language, item.DefaultBranch, dono, licenca);

                repositorios.Add(repositorio);
            }

            return repositorios;
        }
    }
}
