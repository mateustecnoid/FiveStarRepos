using System.Collections.Generic;

namespace FiveStarRepos.Application.Base
{
    public class PagedResultResponse<TEntity> where TEntity : class
    {
        public int Pagina { get; }
        public int TamanhoPagina { get; }
        public int Total { get; }
        public IEnumerable<TEntity> Dados { get; }

        public PagedResultResponse(int pagina, int tamanhoPagina, int total, IEnumerable<TEntity> dados)
        {
            Pagina = pagina;
            TamanhoPagina = tamanhoPagina;
            Total = total;
            Dados = dados;
        }
    }
}
