using FiveStarRepos.Infra.Data.Network.Responses;

namespace FiveStarRepos.UnitTests.Factories
{
    public static class GitHubApiItensResponseFactory
    {
        public static GitHubApiItensResponse Sample => new()
        {
            Name = "PowerToys",
            FullName = "PowerToys",
            Private = false,
            Description = "Windows system utilities to maximize productivity",
            HtmlUrl = new Uri("https://github.com/microsoft/PowerToys"),
            CreatedAt = DateTime.Now.AddDays(-10),
            UpdatedAt = DateTime.Now.AddDays(-1),
            Size = 1000,
            StargazersCount = 1000,
            Language = "C#",
            DefaultBranch = "main",
            Owner = new GitHubApiOwnerResponse()
            {
                Login = "microsoft",
                HtmlUrl = new Uri("https://github.com/microsoft"),
                AvatarUrl = new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                Type = "Organization"
            },
            License = new GitHubApiLicenseResponse()
            {
                Key = "mit",
                Name = "MIT License",
                Url = new Uri("https://api.github.com/licenses/mit")
            }
        };

        public static GitHubApiItensResponse SampleInvalido => new()
        {
            Name = "PowerToys",
            FullName = string.Empty,
            Private = false,
            Description = "Windows system utilities to maximize productivity",
            HtmlUrl = new Uri("https://github.com/microsoft/PowerToys"),
            CreatedAt = DateTime.Now.AddDays(-10),
            UpdatedAt = DateTime.Now.AddDays(-1),
            Size = 0,
            StargazersCount = 0,
            Language = "C#",
            DefaultBranch = "main",
            Owner = new GitHubApiOwnerResponse()
            {
                Login = "microsoft",
                HtmlUrl = new Uri("https://github.com/microsoft"),
                AvatarUrl = new Uri("https://avatars.githubusercontent.com/u/6154722?v=4"),
                Type = "Organization"
            },
            License = new GitHubApiLicenseResponse()
            {
                Key = "mit",
                Name = "MIT License",
                Url = new Uri("https://api.github.com/licenses/mit")
            }
        };

        public static List<GitHubApiItensResponse> SampleLista => new()
        {
            Sample
        };

        public static List<GitHubApiItensResponse> SampleListaInvalido => new()
        {
            SampleInvalido
        };
    }
}
