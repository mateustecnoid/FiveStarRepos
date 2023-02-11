using FiveStarRepos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiveStarRepos.Infra.Data.Repositories.Configurations
{
    public class RepositorioConfiguration : IEntityTypeConfiguration<Repositorio>
    {
        public void Configure(EntityTypeBuilder<Repositorio> builder)
        {
            builder.ToTable(nameof(Repositorio));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.NomeCompleto)
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(x => x.Privado).IsRequired();

            builder.Property(x => x.Url)
                   .HasMaxLength(150)
                   .IsRequired();

            builder.Property(x => x.Descricao)
                   .HasMaxLength(500);

            builder.Property(x => x.DataSincronizacao)
                   .IsRequired();

            builder.Property(x => x.DataCriacaoRepositorio)
                   .IsRequired();

            builder.Property(x => x.DataAtualizacaoRepositorio)
                   .IsRequired();    

            builder.Property(x => x.Tamanho)
                   .IsRequired();

            builder.Property(x => x.Stars)
                   .IsRequired();

            builder.Property(x => x.Linguagem)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.BranchPadrao)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.HasOne(x => x.Dono)
                   .WithOne(y => y.Repositorio)
                   .HasForeignKey<Dono>(z => z.RepositorioId);

            builder.HasOne(x => x.Licenca)
                   .WithOne(y => y.Repositorio)
                   .HasForeignKey<Licenca>(z => z.RepositorioId);
        }
    }
}
