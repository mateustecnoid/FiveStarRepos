using FiveStarRepos.Domain;
using FiveStarRepos.Infra.Data.Repositories.Base.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Data.Repositories.Interfaces
{
    public interface IRepositorioRepository : IBaseRepository<Repositorio>
    {
        Task<IEnumerable<Repositorio>> SearchAsync(string termo, int page, int pageSize);
    }
}
