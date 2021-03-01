using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminSanPhamChiNhanhController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminSanPhamChiNhanh
        public ActionResult SanPhamChiNhanhHaNam()
        {
            var model = db.SANPHAM_CUAHANG.Where(x => x.MaCuaHang == 1);
            return View(model);
        }
        public ActionResult SanPhamChiNhanhThaiBinh()
        {
            var model = db.SANPHAM_CUAHANG.Where(x => x.MaCuaHang == 2);
            return View(model);
        }
        public ActionResult SanPhamChiNhanhPhuTho()
        {
            var model = db.SANPHAM_CUAHANG.Where(x => x.MaCuaHang == 3);
            return View(model);
        }
        public ActionResult SanPhamChiNhanhNgheAn()
        {
            var model = db.SANPHAM_CUAHANG.Where(x => x.MaCuaHang == 4);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(SANPHAM_CUAHANG model)
        {
            var SanPhamCuaHang = db.SANPHAM_CUAHANG.Find(model.MaSPCH);
            db.SANPHAM_CUAHANG.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.SANPHAM_CUAHANG.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(SANPHAM_CUAHANG model)
        {
            var obj = db.SANPHAM_CUAHANG.Find(model.MaSPCH);
            obj.MaSPCH = model.MaSPCH;
            obj.SoLuong = model.SoLuong;
            obj.MaSanPham = model.MaSanPham;
            obj.MaCuaHang = model.MaCuaHang;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }

        public ActionResult Delete(int id)
        {
            var model = db.SANPHAM_CUAHANG.Find(id);
            db.SANPHAM_CUAHANG.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(int masp)
        {
            List<SANPHAM_CUAHANG> model = new List<SANPHAM_CUAHANG>();
            if (masp != 0)
            {
                model = db.SANPHAM_CUAHANG.Where(x => x.MaSanPham == masp).ToList();
            }
            else
            {
                model = db.SANPHAM_CUAHANG.Where(x => x.MaSanPham != null).ToList();
            }
            return View("Index", model);
        }
    }
}