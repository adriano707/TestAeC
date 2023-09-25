using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using User.Domain.Entities;

namespace User.Data.Configuration
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.DDD).HasColumnType("varchar(3)");
            builder.Property(p => p.Number);
        }
    }
}
