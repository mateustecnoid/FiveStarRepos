using FiveStarRepos.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FiveStarRepos.Infra.Data.Repositories.Configurations
{
    public class DonoConfiguration : IEntityTypeConfiguration<Dono>
    {
        public void Configure(EntityTypeBuilder<Dono> builder)
        {
            builder.ToTable(nameof(Dono));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Login)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(x => x.Url)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.AvatarUrl)
                   .HasMaxLength(256)
                   .IsRequired();

            builder.Property(x => x.Tipo)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasOne(x => x.Repositorio)
                   .WithOne(y => y.Dono);
        }
    }
}
