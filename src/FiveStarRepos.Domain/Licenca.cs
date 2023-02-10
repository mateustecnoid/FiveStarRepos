using FiveStarRepos.Domain.Base;
using FiveStarRepos.Domain.Validators;
using System;

namespace FiveStarRepos.Domain
{
    public class Licenca : BaseEntity
    {
        public string Chave { get; protected set; }
        public string Nome { get; protected set; }
        public Uri Url { get; protected set; }
        public long RepositorioId { get; protected set; }
        public virtual Repositorio Repositorio { get; protected set; }

        protected Licenca() { }

        public Licenca(string chave, string nome, Uri url)
        {
            Chave = chave;
            Nome = nome;
            Url = url;
            Validar();
        }

        public override bool Validar() => Validate(this, new LicencaValidation());
    }
}
