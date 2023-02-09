﻿using FiveStarRepos.Infra.Data.Network.Responses;
using System.Threading.Tasks;

namespace FiveStarRepos.Infra.Dados.Network.Interfaces
{
    public interface IRepositorioNetwork
    {
        Task<GitHubApiResponse> GetRepository(string language);
    }
}