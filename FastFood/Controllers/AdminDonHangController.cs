using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminDonHangController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminDonHang
        public ActionResult Index()
        {
            var model = db.DONHANGs.Where(x => x.MaDonHang != 0);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(DONHANG model)
        {
            var DonHang = db.DONHANGs.Find(model.MaDonHang);
            db.DONHANGs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.DONHANGs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(DONHANG model)
        {
            var obj = db.DONHANGs.Find(model.MaDonHang);
            obj.MaDonHang = model.MaDonHang;
            obj.TrangThai = model.TrangThai;
            obj.NgayDat = model.NgayDat;
            obj.NgayGiao = model.NgayGiao;
            obj.ThanhTien = model.ThanhTien;
            obj.MaNguoiDung = model.MaNguoiDung;
            obj.MaKhachHang = model.MaKhachHang;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.DONHANGs.Find(id);
            db.DONHANGs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(int MaKH)
        {
            List<DONHANG> model = new List<DONHANG>();
            if (MaKH != 0)
            {
                model = db.DONHANGs.Where(x => x.MaKhachHang == MaKH).ToList();
            }
            else
            {
                model = db.DONHANGs.Where(x => x.MaKhachHang != null).ToList();
            }
            return View("Index", model);
        }
    }
}