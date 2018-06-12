namespace WebBanMyPham.DataBase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NhanVien")]
    public partial class NhanVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NhanVien()
        {
            HoaDonBans = new HashSet<HoaDonBan>();
        }

        [Key]
        public int MaNV { get; set; }

        public string TenNV { get; set; }

        [StringLength(8000)]
        public string AnhDaiDien { get; set; }

        public string SDT { get; set; }

        public string GioiTinh { get; set; }

        public DateTime NgaySinh { get; set; }

        public double Luong { get; set; }

        public int MaACC { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
