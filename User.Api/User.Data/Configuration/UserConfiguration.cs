using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace User.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<Domain.Entities.User>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name).HasColumnType("varchar(150)");
            builder.Property(u => u.BirthDate);
            builder.Property(u => u.CPF).HasColumnType("varchar(11)");
        }
    }
}
