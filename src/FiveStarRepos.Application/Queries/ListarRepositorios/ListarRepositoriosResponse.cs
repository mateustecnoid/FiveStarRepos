using FiveStarRepos.Domain;
using System;

namespace FiveStarRepos.Application.Queries.Repositorios
{
    public class ListarRepositoriosResponse
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public bool Privado { get; set; }
        public Uri Url { get; set; }
        public string Descricao { get;  set; }
        public DateTime DataCriacaoRepositorio { get; set; }
        public DateTime DataAtualizacaoRepositorio { get; set; }
        public long Tamanho { get; set; }
        public long Stars { get; set; }
        public string Linguagem { get; set; }
        public string BranchPadrao { get; set; }
        public string Dono { get; set; }

        public ListarRepositoriosResponse(Repositorio repositorio)
        {
            Id = repositorio.Id;
            Nome = repositorio.Nome;
            NomeCompleto = repositorio.NomeCompleto;
            Privado = repositorio.Privado;
            Url = repositorio.Url;
            Descricao = repositorio.Descricao;
            DataCriacaoRepositorio = repositorio.DataCriacaoRepositorio;
            DataAtualizacaoRepositorio = repositorio.DataAtualizacaoRepositorio;
            Tamanho = repositorio.Tamanho;
            Stars = repositorio.Stars;
            Linguagem = repositorio.Linguagem;
            BranchPadrao = repositorio.BranchPadrao;
            Dono = repositorio.Dono.Login;
        }
    }
}
