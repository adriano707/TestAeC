using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using User.Domain.Entities;

namespace User.Data.Configuration
{
    public class OccupationConfiguration : IEntityTypeConfiguration<Occupation>
    {
        public void Configure(EntityTypeBuilder<Occupation> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.NameOccupation).HasColumnType("varchar(100)");
        }
    }
}
