using FiveStarRepos.Domain;
using Microsoft.EntityFrameworkCore;

namespace FiveStarRepos.Infra.Data.Repositories.Contexts
{
    public class FiveStarReposContext : DbContext
    {
        public DbSet<Repositorio> Repositorios { get; set; }
        public DbSet<Dono> Donos { get; set; }
        public DbSet<Licenca> Licencas { get; set; }

        public FiveStarReposContext(DbContextOptions<FiveStarReposContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(typeof(FiveStarReposContext).Assembly);
            base.OnModelCreating(builder);
        }
    }
}
