using FiveStarRepos.Domain;
using System;

namespace FiveStarRepos.Application.Queries.Detalhes
{
    public class DetalheRepositorioResponse
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public bool Privado { get; set; }
        public Uri Url { get; set; }
        public string Descricao { get; set; }
        public DateTime DataSincronizacao { get; set; }
        public DateTime DataCriacaoRepositorio { get; set; }
        public DateTime DataAtualizacaoRepositorio { get; set; }
        public long Tamanho { get; set; }
        public long Stars { get; set; }
        public string Linguagem { get; set; }
        public string BranchPadrao { get; set; }
        public DetalheRepositorioDonoResponse Dono { get; set; }
        public DetalheRepositorioLicencaResponse Licenca { get; set; }

        public DetalheRepositorioResponse(Repositorio repositorio)
        {
            Id = repositorio.Id;
            Nome = repositorio.Nome;
            NomeCompleto = repositorio.NomeCompleto;
            Privado = repositorio.Privado;
            Url = repositorio.Url;
            Descricao = repositorio.Descricao;
            DataSincronizacao = repositorio.DataSincronizacao;
            DataCriacaoRepositorio = repositorio.DataCriacaoRepositorio;
            DataAtualizacaoRepositorio = repositorio.DataAtualizacaoRepositorio;
            Tamanho = repositorio.Tamanho;
            Stars = repositorio.Stars;
            Linguagem = repositorio.Linguagem;
            BranchPadrao = repositorio.BranchPadrao;
            Dono = new DetalheRepositorioDonoResponse(repositorio.Dono);
            Licenca = repositorio.Licenca is not null ? new DetalheRepositorioLicencaResponse(repositorio.Licenca) : null;
        }
    }
}
