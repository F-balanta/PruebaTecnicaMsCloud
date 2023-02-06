using Juan_Felipe_Balanta_Renteria.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Juan_Felipe_Balanta_Renteria.Configurations
{
    public class TableroConfiguration : IEntityTypeConfiguration<TableroEntity>
    {
        public void Configure(EntityTypeBuilder<TableroEntity> builder)
        {
            builder.ToTable("Tablero");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Pais)
                .IsRequired()
                .HasMaxLength(3);
            builder.Property(x => x.TotalPeso)
                .IsRequired();

            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(x => x.Arranque)
                .IsRequired();

            builder.Property(x => x.Envion)
                .IsRequired();
        }
    }
}
