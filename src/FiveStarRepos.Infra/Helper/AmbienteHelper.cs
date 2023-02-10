using System;

namespace FiveStarRepos.Infra.Dados.Helper
{
    public static class AmbienteHelper
    {
        public static string[] Linguagens => Environment.GetEnvironmentVariable("Linguagens").Split(";");
    }
}
