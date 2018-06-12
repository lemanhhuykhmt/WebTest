using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebBanMyPham.DataBase.DAO;
using WebBanMyPham.DataBase.EF;

namespace WebBanMyPham.Areas.Admin.Controllers
{
    public class SanPhamController : BaseController
    {
        // GET: Admin/SanPham
        public ActionResult Index()// danh sách sản phầm
        {
            var sanPhams = SanPhamDAO.GetList();
            return View(sanPhams);
        }
        
        [HttpGet]
        public ActionResult Create()
        {
            setViewBagLoaiSP();
            return View();
        }

        [HttpPost]
        public ActionResult Create(SanPham sanpham)
        {
            if(ModelState.IsValid)
            {
                SanPhamDAO.Insert(sanpham);
                return RedirectToAction("Index");
            }
            setViewBagLoaiSP();
            return View();
        }
        private void setViewBagLoaiSP(int? id = null)
        {
            List<LoaiSP> listLoai = LoaiSPDAO.getListLoaiSP();
            SelectList slLoai = new SelectList(listLoai, "MaLoaiSP", "TenLoaiSP", id);
            ViewBag.slLoai = slLoai;
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SanPham sanPham = SanPhamDAO.GetByID(id);
            if (sanPham == null)
            {
                return HttpNotFound();
            }
            setViewBagLoaiSP(sanPham.MaLoaiSP);
            return View(sanPham);
        }

        [HttpPost]
        public ActionResult Edit(SanPham sanpham)
        {
            if(ModelState.IsValid)
            {
                SanPhamDAO.Update(sanpham);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            SanPhamDAO.Delete(id);
            return RedirectToAction("Index");
        }
    }
}