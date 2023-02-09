using FiveStarRepos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiveStarRepos.Infra.Data.Repositories.Configurations
{
    public class LicencaConfiguration : IEntityTypeConfiguration<Licenca>
    {
        public void Configure(EntityTypeBuilder<Licenca> builder)
        {
            builder.ToTable(nameof(Licenca));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Chave)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.Nome)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(x => x.Url)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasOne(x => x.Repositorio)
                   .WithOne(y => y.Licenca);
        }
    }
}
