using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminChiNhanhController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminChiNhanh
        public ActionResult Index()
        {
            var model = db.CUAHANGs.Where(x => x.Ten != null);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        } 
        [HttpPost]
        public ActionResult Add(CUAHANG model)
        {
            var ChiNhanh = db.CUAHANGs.Find(model.MaCuaHang);
            db.CUAHANGs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Edit(int? id)
        {
            var model = db.CUAHANGs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(CUAHANG model)
        {
            var obj = db.CUAHANGs.Find(model.MaCuaHang);
            obj.MaCuaHang = model.MaCuaHang;
            obj.Ten = model.Ten;
            obj.SDT = model.SDT;
            obj.TrangThai = model.TrangThai;
            obj.MaXa = model.MaXa;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.CUAHANGs.Find(id);
            db.CUAHANGs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<CUAHANG> model = new List<CUAHANG>();
            if (Ten != "")
            {
                model = db.CUAHANGs.Where(x => x.Ten == Ten).ToList();
            }
            else
            {
                model = db.CUAHANGs.Where(x => x.Ten != null).ToList();
            }
            return View("Index", model);
        }
    }
}