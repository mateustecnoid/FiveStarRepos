using FiveStarRepos.Domain;
using FiveStarRepos.Infra.Data.Repositories.Base;
using FiveStarRepos.Infra.Data.Repositories.Contexts;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;

namespace FiveStarRepos.Infra.Data.Repositories
{
    public class RepositorioRepository : BaseRepository<Repositorio>, IRepositorioRepository
    {
        public RepositorioRepository(FiveStarReposContext componenteContext) : base(componenteContext)
        {
        }
    }
}
