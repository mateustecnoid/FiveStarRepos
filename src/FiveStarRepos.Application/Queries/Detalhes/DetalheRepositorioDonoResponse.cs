using FiveStarRepos.Domain;
using System;

namespace FiveStarRepos.Application.Queries.Detalhes
{
    public class DetalheRepositorioDonoResponse
    {
        public string Login { get; set; }
        public Uri Url { get; set; }
        public Uri AvatarUrl { get; set; }
        public string Tipo { get; set; }

        public DetalheRepositorioDonoResponse(Dono dono)
        {
            Login = dono.Login;
            Url = dono.Url;
            AvatarUrl = dono.AvatarUrl;
            Tipo = dono.Tipo;
        }
    }
}
