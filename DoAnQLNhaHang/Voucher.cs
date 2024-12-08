namespace DoAnQLNhaHang
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Voucher")]
    public partial class Voucher
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Voucher()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string Code_Voucher { get; set; }

        [StringLength(50)]
        public string LoaiVoucher { get; set; }

        public int? GiamGia { get; set; }

        [StringLength(8)]
        public string NguoiDungID { get; set; }

        public int? HanSuDung { get; set; }

        public decimal? GiaTriToiThieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
