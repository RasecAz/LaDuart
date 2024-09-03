

using LaDuartProject.Server.Entityes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LaDuartProject.Infraestructure.Data.Config
{
    public class Productocofiguration : IEntityTypeConfiguration<Productos>
    {
        public void Configure(EntityTypeBuilder<Productos> builder)
        {
            builder.ToTable("Productos", schema: "dbo");

            builder.HasKey(e => e.Id_producto).HasName("id");
            builder.Property(e => e.Nombre).HasMaxLength(70);
            builder.Property(e => e.Descripcion).HasMaxLength(70);
            builder.Property(e => e.Fecha_creacion).HasColumnType("datetime");
            builder.Property(e => e.Fecha_ingreso).HasColumnType("datetime");
            builder.Property(e => e.Fecha_caducidad).HasColumnType("datetime");
            builder.Property(e => e.Cantidad).HasColumnType("float");
            builder.Property(e => e.Precio).HasColumnType("precio");
        }
    }
}
