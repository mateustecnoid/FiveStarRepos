using Refit;

namespace FiveStarRepos.Infra.Data.Network.Requests
{
    public class TopFiveReposRequest
    {
        [AliasAs("q")]
        public string Query { get; set; }

        [AliasAs("sort")]
        public string CampoOrdenacao { get; set; } = "stars";

        [AliasAs("order")]
        public string TipoOrdenacao { get; set; } = "desc";

        [AliasAs("page")]
        public int Pagina { get; set; } = 1;

        [AliasAs("per_page")]
        public int Quantidade { get; set; } = 5;
    }
}
