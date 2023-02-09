using FiveStarRepos.Domain;
using System;

namespace FiveStarRepos.Application.Queries.Detalhes
{
    public class DetalheRepositorioLicencaResponse
    {
        public string Chave { get; set; }
        public string Nome { get; set; }
        public Uri Url { get; set; }

        public DetalheRepositorioLicencaResponse(Licenca licenca)
        {
            Chave = licenca.Chave;
            Nome = licenca.Nome;
            Url = licenca.Url;
        }
    }
}
