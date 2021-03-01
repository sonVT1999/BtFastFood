using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminNguoiDungController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminNguoiDung
        public ActionResult Index()
        {
            var model = db.NGUOIDUNGs.Where(x => x.MaNguoiDung != 0);
            return View(model);
        }


        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(NGUOIDUNG model)
        {
            var NguoiDung = db.NGUOIDUNGs.Find(model.MaNguoiDung);
            db.NGUOIDUNGs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.NGUOIDUNGs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(NGUOIDUNG model)
        {
            var obj = db.NGUOIDUNGs.Find(model.MaNguoiDung);
            obj.MaNguoiDung = model.MaNguoiDung;
            obj.Ten = model.Ten;
            obj.ViTri = model.ViTri;
            obj.TaiKhoan = model.TaiKhoan;
            obj.MaNguoiDung = model.MaNguoiDung;
            obj.NgaySinh = model.NgaySinh;
            obj.MaCuaHang = model.MaCuaHang;

            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.NGUOIDUNGs.Find(id);
            db.NGUOIDUNGs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<NGUOIDUNG> model = new List<NGUOIDUNG>();
            if (Ten != "")
            {
                model = db.NGUOIDUNGs.Where(x => x.Ten == Ten).ToList();
            }
            else
            {
                model = db.NGUOIDUNGs.Where(x => x.Ten != null).ToList();
            }
            return View("Index", model);
        }
    }
}