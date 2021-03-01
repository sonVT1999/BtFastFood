using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminDanhMucSPController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminDanhMucSP
        public ActionResult Index()
        {
            var model = db.DANHMUCSANPHAMs.Where(x => x.MaDM != 0);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(DANHMUCSANPHAM model)
        {
            var DanhMucSanPham = db.DANHMUCSANPHAMs.Find(model.MaDM);
            db.DANHMUCSANPHAMs.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var model = db.DANHMUCSANPHAMs.Find(id);
            db.DANHMUCSANPHAMs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.DANHMUCSANPHAMs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(DANHMUCSANPHAM model)
        {
            var obj = db.DANHMUCSANPHAMs.Find(model.MaDM);
            obj.MaDM = model.MaDM;
            obj.Ten = model.Ten;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<DANHMUCSANPHAM> model = new List<DANHMUCSANPHAM>();
            if (Ten != "")
            {
                model = db.DANHMUCSANPHAMs.Where(x => x.Ten == Ten).ToList();
            }
            else
            {
                model = db.DANHMUCSANPHAMs.Where(x => x.Ten != null).ToList();
            }
            return View("Index", model);
        }
    }
}