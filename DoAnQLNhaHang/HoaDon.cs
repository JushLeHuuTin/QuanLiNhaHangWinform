namespace DoAnQLNhaHang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        public int ID_HoaDon { get; set; }

        public int? ID_Ban { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayLap { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCheckout { get; set; }

        [StringLength(10)]
        public string MaVoucher { get; set; }

        [StringLength(20)]
        public string TrangThai { get; set; }

        public double? ThanhTien { get; set; }

        public virtual Voucher Voucher { get; set; }
    }
}
