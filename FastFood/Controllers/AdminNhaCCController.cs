using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class AdminNhaCCController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: AdminNhaCC
        public ActionResult Index()
        {
            var model = db.NHACUNGCAPs.Where(x => x.Ten != null);
            return View(model);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(NHACUNGCAP model)
        {
            var NhaCungCap = db.NHACUNGCAPs.Find(model.MaNCC);
            db.NHACUNGCAPs.Add(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Edit(int? id)
        {
            var model = db.NHACUNGCAPs.Find(id);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(NHACUNGCAP model)
        {
            var obj = db.NHACUNGCAPs.Find(model.MaNCC);
            obj.Ten = model.Ten;
            obj.SDT = model.SDT;
            obj.MaXa = model.MaXa;
            db.SaveChanges();
            return RedirectToAction("index", model);
        }
        public ActionResult Delete(int id)
        {
            var model = db.NHACUNGCAPs.Find(id);
            db.NHACUNGCAPs.Remove(model);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpPost]
        public ActionResult Search(string Ten)
        {
            List<NHACUNGCAP> model = new List<NHACUNGCAP>();
            if (Ten != "")
            {
                model = db.NHACUNGCAPs.Where(x => x.Ten == Ten).ToList();
            }
            else
            {
                model = db.NHACUNGCAPs.Where(x => x.Ten != null).ToList();
            }
            return View("Index", model);
        }
    }
}