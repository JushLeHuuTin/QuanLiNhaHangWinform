using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DoAnQLNhaHang
{
    public partial class DataHoaDon : DbContext
    {
        public DataHoaDon()
            : base("name=DataHoaDon")
        {
        }

        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaVoucher)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.Code_Voucher)
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.NguoiDungID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Voucher>()
                .Property(e => e.GiaTriToiThieu)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Voucher>()
                .HasMany(e => e.HoaDon)
                .WithOptional(e => e.Voucher)
                .HasForeignKey(e => e.MaVoucher);
        }
    }
}
