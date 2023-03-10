using FiveStarRepos.Domain;
using FiveStarRepos.Infra.Data.Repositories.Base;
using FiveStarRepos.Infra.Data.Repositories.Contexts;
using FiveStarRepos.Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Repositories
{
    public class RepositorioRepository : BaseRepository<Repositorio>, IRepositorioRepository
    {
        public RepositorioRepository(FiveStarReposContext componenteContext) : base(componenteContext)
        {
        }

        public async Task<IEnumerable<Repositorio>> SearchAsync(string termo, int page, int pageSize)
        {
            var repositorios = Set.AsQueryable();

            if (!string.IsNullOrEmpty(termo))
            {
                repositorios = repositorios.Where(x => x.Nome.Contains(termo) ||
                                                       x.NomeCompleto.Contains(termo) ||
                                                       x.Descricao.Contains(termo) ||
                                                       x.Linguagem.Contains(termo) ||
                                                       x.BranchPadrao.Contains(termo) ||
                                                       x.Dono.Login.Contains(termo) ||
                                                       x.Licenca.Nome.Contains(termo));
            }

            return await repositorios.Skip((page - 1) * pageSize)
                                     .Take(pageSize)
                                     .OrderByDescending(x => x.Stars)
                                     .ToListAsync();
        }
    }
}
