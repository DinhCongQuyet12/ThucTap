using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public DbSet<HangHoa> HangHoas { set; get; }
        public DbSet<Loai> Loais { set; get; }
        public DbSet<DonHang> DonHangs { set; get; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { set; get; }

        #endregion
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(e =>
            {
                e.ToTable("DonHang");
                e.HasKey(dh => dh.MaDh);
                e.Property(dh => dh.NgayDat).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.NguoiNhan).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<DonHangChiTiet>(entity =>
            {
                entity.ToTable("ChiTietDonHang");
                entity.HasKey(e => new { e.MaDh, e.MaHh});

                entity.HasOne(e => e.DonHang)
                      .WithMany(e => e.DonHangChiTiets)
                      .HasForeignKey(e => e.MaDh)
                      .HasConstraintName("FK_DonHangCt_DonHang");


                entity.HasOne(e => e.HangHoa)
                      .WithMany(e => e.DonHangChiTiets)
                      .HasForeignKey(e => e.MaHh)
                      .HasConstraintName("FK_DonHangCt_HangHoa");
            });
        }

    }
}
