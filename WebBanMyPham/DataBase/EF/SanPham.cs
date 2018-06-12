namespace WebBanMyPham.DataBase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SanPham")]
    public partial class SanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SanPham()
        {
            ChiTietHDBs = new HashSet<ChiTietHDB>();
        }

        [Key]
        [DisplayName("Mã SP")]
        public int MaSP { get; set; }

        [StringLength(8000)]
        [DisplayName("Ảnh")]
        public string AnhDaiDien { get; set; }

        [DisplayName("Tên Sản Phẩm")]
        public string TenSP { get; set; }

        [DisplayName("Tên Loại")]
        public int? MaLoaiSP { get; set; }

        [DisplayName("Đơn Giá")]
        public double DonGia { get; set; }

        [DisplayName("Đơn Vị")]
        public string DonViDo { get; set; }

        [DisplayName("Số Lượng")]
        public int SoLuong { get; set; }

        [DisplayName("Trạng Thái")]
        public bool TrangThai { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietHDB> ChiTietHDBs { get; set; }

        public virtual LoaiSP LoaiSP { get; set; }
    }
}
