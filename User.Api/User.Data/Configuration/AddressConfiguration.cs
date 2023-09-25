using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using User.Domain.Entities.Address;

namespace User.Data.Configuration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasColumnType("varchar(150)");
            builder.Property(a => a.City).HasColumnType("varchar(100)");
            builder.Property(a => a.Complement).HasColumnType("varchar(100)");
            builder.Property(a => a.District).HasColumnType("varchar(100)");
            builder.Property(a => a.Number).HasColumnType("varchar(20)");
            builder.Property(a => a.State).HasColumnType("varchar(100)");
            builder.Property(a => a.UF).HasColumnType("varchar(2)");
        }
    }
}
