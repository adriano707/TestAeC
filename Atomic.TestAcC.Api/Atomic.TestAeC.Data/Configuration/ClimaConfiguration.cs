using Atomic.Test.AeC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atomic.TestAeC.Data.Configuration
{
    public class ClimaConfiguration : IEntityTypeConfiguration<CityClimate>
    {
        public void Configure(EntityTypeBuilder<CityClimate> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Data).IsRequired();
            builder.Property(c => c.Condicao).HasColumnType("varchar(50)");
            builder.Property(c => c.Min);
            builder.Property(c => c.Max);
            builder.Property(c => c.IndiceUv).IsRequired();
            builder.Property(c => c.CondicaoDesc).IsRequired().HasColumnType("varchar(50)");
        }
    }
}
