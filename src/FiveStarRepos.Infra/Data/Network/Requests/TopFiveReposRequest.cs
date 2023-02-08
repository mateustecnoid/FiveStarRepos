using Refit;

namespace FiveStarRepos.Infra.Data.Network.Requests
{
    public class TopFiveReposRequest
    {
        [AliasAs("q")]
        public string Query { get; set; }

        [AliasAs("sort")]
        public string CampoOrdenacao { get; set; }

        [AliasAs("order")]
        public string TipoOrdenacao { get; set; }

        [AliasAs("page")]
        public int Pagina { get; set; }

        [AliasAs("per_page")]
        public int Quantidade { get; set; }
    }
}
