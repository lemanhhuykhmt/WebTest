namespace WebBanMyPham.DataBase.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHDB")]
    public partial class ChiTietHDB
    {
        [Key]
        public int MaChiTiet { get; set; }

        public int MaSP { get; set; }

        public int MaHDB { get; set; }

        public int SoLuong { get; set; }

        public double GiaTien { get; set; }

        public virtual HoaDonBan HoaDonBan { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
