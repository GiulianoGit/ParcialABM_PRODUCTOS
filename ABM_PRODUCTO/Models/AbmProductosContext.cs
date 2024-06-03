using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ABM_PRODUCTO.Models;

public partial class ABM_PRODUCTOContext : DbContext
{
    public ABM_PRODUCTOContext()
    {
    }

    public ABM_PRODUCTOContext(DbContextOptions<ABM_PRODUCTOContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Producto> Productos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-LV97F8K\\SQLEXPRESS;Initial Catalog=ABM_Productos;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__09889210F1947FCA");

            entity.Property(e => e.FechaVencimiento)
                .HasColumnType("datetime")
                .HasColumnName("Fecha_Vencimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Tipo)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
