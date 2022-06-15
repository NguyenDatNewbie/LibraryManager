using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BanTest.Model
{
    public partial class QLTVModel : DbContext
    {
        public QLTVModel()
            : base("name=QLTVModelEntity")
        {
        }

        public virtual DbSet<Muon> Muons { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<NXB> NXBs { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }
        public virtual DbSet<TheLoai> TheLoais { get; set; }
        public virtual DbSet<Tra> Tras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Muon>()
                .Property(e => e.maSV)
                .IsUnicode(false);

            modelBuilder.Entity<Muon>()
                .Property(e => e.maSach)
                .IsUnicode(false);

            modelBuilder.Entity<Muon>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.pathImg)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NXB>()
                .Property(e => e.maNXB)
                .IsUnicode(false);

            modelBuilder.Entity<NXB>()
                .Property(e => e.sdt)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.maSach)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.maTL)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .Property(e => e.maNXB)
                .IsUnicode(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.Muons)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sach>()
                .HasMany(e => e.Tras)
                .WithRequired(e => e.Sach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.maSV)
                .IsUnicode(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Muons)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.Tras)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.taiKhoan)
                .IsUnicode(true);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.matKhau)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoan>()
                .Property(e => e.maNV)
                .IsUnicode(false);

            modelBuilder.Entity<TheLoai>()
                .Property(e => e.maTL)
                .IsUnicode(false);

            modelBuilder.Entity<Tra>()
                .Property(e => e.maSV)
                .IsUnicode(false);

            modelBuilder.Entity<Tra>()
                .Property(e => e.maSach)
                .IsUnicode(false);

            modelBuilder.Entity<Tra>()
                .Property(e => e.maNV)
                .IsUnicode(false);
        }
    }
}
