using System.Collections.Generic;

namespace FiveStarRepos.Application.Base
{
    public class ResultResponse<TEntity> where TEntity : class
    {
        public bool Sucesso { get; set; }
        public TEntity Dado { get; set; }
        public IEnumerable<string> Falhas { get; set; }

        public static ResultResponse<TEntity> BuildSucesso()
        {
            return new()
            {
                Sucesso = true
            };
        }

        public static ResultResponse<TEntity> BuildSucesso(TEntity dado)
        {
            return new()
            {
                Dado = dado,
                Sucesso = true
            };
        }

        public static ResultResponse<TEntity> BuildFalha(IEnumerable<string> falhas)
        {
            return new()
            {
                Falhas = falhas,
                Sucesso = false
            };
        }
        public static ResultResponse<TEntity> BuildFalha(string falha)
        {
            return new()
            {
                Falhas = new List<string> { falha },
                Sucesso = false
            };
        }
    }
}
