using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atomic.Test.AeC.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atomic.TestAeC.Data.Configuration
{
    public class ClimaCidadeConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Cidade).IsRequired().HasColumnType("varchar(255)");
            builder.Property(c => c.Estado).IsRequired().HasColumnType("varchar(50)");
            builder.Property(c => c.AtualziadoEm).IsRequired();

            builder.HasMany(c => c.ClimaList)
                .WithOne()
                .HasForeignKey(cl => cl.CidadeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
