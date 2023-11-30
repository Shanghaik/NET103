using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Three_Layer.Models
{
    public partial class LuyenTapContext : DbContext
    {
        public LuyenTapContext()
        {
        }

        public LuyenTapContext(DbContextOptions<LuyenTapContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Sinhvien> Sinhviens { get; set; } = null!;
        public virtual DbSet<TruongHoc> TruongHocs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=SHANGHAIK;Database=LuyenTap;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.ToTable("Sinhvien");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Idtruong).HasColumnName("idtruong");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Ten)
                    .HasMaxLength(200)
                    .HasColumnName("ten");

                entity.HasOne(d => d.IdtruongNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.Idtruong)
                    .HasConstraintName("FK_SV_TH");
            });

            modelBuilder.Entity<TruongHoc>(entity =>
            {
                entity.ToTable("TruongHoc");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(200)
                    .HasColumnName("diachi");

                entity.Property(e => e.Ngaythanhlap)
                    .HasColumnType("date")
                    .HasColumnName("ngaythanhlap");

                entity.Property(e => e.Ten)
                    .HasMaxLength(200)
                    .HasColumnName("ten");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
