using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace studentManager_DTO
{
    public partial class dbStudentManager : DbContext
    {
        public dbStudentManager()
            : base("data source=.;initial catalog=QLHV;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework")
        {
        }

        public virtual DbSet<BIEN_LAI> BIEN_LAI { get; set; }
        public virtual DbSet<CA_HOC> CA_HOC { get; set; }
        public virtual DbSet<DANG_KI> DANG_KI { get; set; }
        public virtual DbSet<DAY_HOC> DAY_HOC { get; set; }
        public virtual DbSet<DIEN_GIAM_PHI> DIEN_GIAM_PHI { get; set; }
        public virtual DbSet<GIAM_PHI> GIAM_PHI { get; set; }
        public virtual DbSet<GIAO_VIEN> GIAO_VIEN { get; set; }
        public virtual DbSet<HOC_VIEN> HOC_VIEN { get; set; }
        public virtual DbSet<KITHI> KITHI { get; set; }
        public virtual DbSet<KHOA_HOC> KHOA_HOC { get; set; }
        public virtual DbSet<LOAIPHONG> LOAIPHONG { get; set; }
        public virtual DbSet<LOPHOC> LOPHOC { get; set; }
        public virtual DbSet<MONHOC> MONHOC { get; set; }
        public virtual DbSet<PHONGHOC> PHONGHOC { get; set; }
        public virtual DbSet<THI> THI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BIEN_LAI>()
                .HasMany(e => e.DANG_KI)
                .WithRequired(e => e.BIEN_LAI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BIEN_LAI>()
                .HasMany(e => e.HOC_VIEN)
                .WithMany(e => e.BIEN_LAI)
                .Map(m => m.ToTable("XUAT").MapLeftKey("MABL").MapRightKey("MAHOCVIEN"));

            modelBuilder.Entity<DAY_HOC>()
                .Property(e => e.MAMON)
                .IsFixedLength();

            modelBuilder.Entity<DAY_HOC>()
                .Property(e => e.MAGIAOVIEN)
                .IsFixedLength();

            modelBuilder.Entity<DAY_HOC>()
                .Property(e => e.MADAYHOC)
                .IsFixedLength();

            modelBuilder.Entity<DIEN_GIAM_PHI>()
                .HasMany(e => e.GIAM_PHI)
                .WithRequired(e => e.DIEN_GIAM_PHI)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HOC_VIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<HOC_VIEN>()
                .HasMany(e => e.THI)
                .WithRequired(e => e.HOC_VIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KITHI>()
                .HasOptional(e => e.THI)
                .WithRequired(e => e.KITHI);

            modelBuilder.Entity<KHOA_HOC>()
                .HasMany(e => e.MONHOC)
                .WithRequired(e => e.KHOA_HOC)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHONGHOC>()
                .HasMany(e => e.THI)
                .WithRequired(e => e.PHONGHOC)
                .WillCascadeOnDelete(false);
        }
    }
}
