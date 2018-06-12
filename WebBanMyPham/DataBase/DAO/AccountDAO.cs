using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanMyPham.DataBase.EF;

namespace WebBanMyPham.DataBase.DAO
{
    public static class AccountDAO
    {
        private static MyPhamContext db = new MyPhamContext();
        public static bool Login(string username, string password)
        {
            var res = db.Accounts.Count(x=>x.TenDangNhap == username && x.MatKhau == password && x.Quyen == 1);
            if(res > 0)
            {
                return true;
            }
            return false;
        }
        public static Account GetByUserName(string username)
        {
            return db.Accounts.SingleOrDefault(x => x.TenDangNhap == username);
        }
    }
}