using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Models;

public partial class ProductosContext : DbContext
{
    public ProductosContext()
    {
    }

    public ProductosContext(DbContextOptions<ProductosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=ASUS\\SQLEXPRESS; database=PRODUCTOS; integrated security=true; TrustServerCertificate=Yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.intProducto).HasName("PK__Producto__FCE3CB4A51EB8DD1");

            entity.Property(e => e.intProducto).HasColumnName("intProducto");
            entity.Property(e => e.datFechaRegistro).HasColumnName("datFechaRegistro");
            entity.Property(e => e.dblCantidad).HasColumnName("dblCantidad");
            entity.Property(e => e.dblPrecio).HasColumnName("dblPrecio");
            entity.Property(e => e.strClave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strClave");
            entity.Property(e => e.strNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("strNombre");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
