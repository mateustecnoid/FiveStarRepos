using System;

namespace FiveStarRepos.Application.Commands.Criacao
{
    public class CriarRepositorioResponse
    {
        public DateTime DataSincronizacao { get; set; }

        public CriarRepositorioResponse(DateTime dataSincronizacao) { DataSincronizacao = dataSincronizacao; }
    }
}
