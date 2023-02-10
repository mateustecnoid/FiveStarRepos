using FiveStarRepos.Domain.Base;
using FiveStarRepos.Domain.Validators;
using System;

namespace FiveStarRepos.Domain
{
    public class Dono : BaseEntity
    {
        public string Login { get; protected set; }
        public Uri Url { get; protected set; }
        public Uri AvatarUrl { get; protected set; }
        public string Tipo { get; protected set; }
        public long RepositorioId { get; protected set; }
        public virtual Repositorio Repositorio { get; protected set; }

        protected Dono() { }

        public Dono(string login, Uri url, Uri avatarUrl, string tipo)
        {
            Login = login;
            Url = url;
            AvatarUrl = avatarUrl;
            Tipo = tipo;
            Validar();
        }

        public override bool Validar() => Validate(this, new DonoValidation());
    }
}
