using FiveStarRepos.Domain.Base;
using FiveStarRepos.Domain.Validators;
using System;

namespace FiveStarRepos.Domain
{
    public class Repositorio : BaseEntity
    {
        public string Nome { get; protected set; }
        public string NomeCompleto { get; protected set; }
        public bool Privado { get; protected set; }
        public Uri Url { get; protected set; }
        public string Descricao { get; protected set; }
        public DateTime DataSincronizacao { get; set; }
        public DateTime DataCriacaoRepositorio { get; protected set; }
        public DateTime DataAtualizacaoRepositorio { get; protected set; }
        public long Tamanho { get; protected set; }
        public long Stars { get; protected set; }
        public string Linguagem { get; protected set; }
        public string BranchPadrao { get; protected set; }

        public virtual Dono Dono { get; protected set; }
        public virtual Licenca Licenca { get; protected set; }

        protected Repositorio() { }

        public Repositorio(string nome, string nomeCompleto, bool privado, Uri url, string descricao, DateTime dataCriacaoRepositorio, DateTime dataAtualizacaoRepositorio, long tamanho,
                           long stars, string linguagem, string branchPadrao, Dono dono, Licenca licenca)
        {
            Nome = nome;
            NomeCompleto = nomeCompleto;
            Privado = privado;
            Url = url;
            Descricao = descricao;
            DataCriacaoRepositorio = dataCriacaoRepositorio;
            DataAtualizacaoRepositorio = dataAtualizacaoRepositorio;
            Tamanho = tamanho;
            Stars = stars;
            Linguagem = linguagem;
            BranchPadrao = branchPadrao;
            Dono = dono;
            Licenca = licenca;

            DataSincronizacao = DateTime.UtcNow;
            Validar();
        }

        public override bool Validar() => Validate(this, new RepositorioValidation());
    }
}
