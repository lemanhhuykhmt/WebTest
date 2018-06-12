using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanMyPham.DataBase.EF;

namespace WebBanMyPham.DataBase.DAO
{
    public static class LoaiSPDAO
    {
        private static MyPhamContext db = new MyPhamContext();
        public static List<LoaiSP> getListLoaiSP()
        {
            return (from p in db.LoaiSPs where p.LoaiSPCha != null select p).ToList();
        }
        public static int Insert(LoaiSP entity)
        {
            db.LoaiSPs.Add(entity);
            db.SaveChanges();
            return entity.MaLoaiSP;
        }
    }
}