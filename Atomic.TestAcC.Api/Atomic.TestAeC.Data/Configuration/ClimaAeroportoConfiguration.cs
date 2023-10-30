using Atomic.Test.AeC.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Atomic.TestAeC.Data.Configuration
{
    public class ClimaAeroportoConfiguration : IEntityTypeConfiguration<HistoricAirportClimate>
    {
        public void Configure(EntityTypeBuilder<HistoricAirportClimate> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.CodigoIcao).HasColumnType("varchar(4)");
            builder.Property(a => a.AtualizadoEm);
            builder.Property(a => a.PressaoAtmosferica).HasColumnType("varchar(50)");
            builder.Property(a => a.Visibilidade).HasColumnType("varchar(50)");
            builder.Property(a => a.Vento);
            builder.Property(a => a.DirecaoVento);
            builder.Property(a => a.Umidade);
            builder.Property(a => a.CodigoIcao).HasColumnType("varchar(50)");
            builder.Property(a => a.CondicaoDesc);
        }
    }
}
