using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FastFood.Models;

namespace FastFood.Controllers
{
    public class LoginController : Controller
    {
        FastFooddb db = new FastFooddb();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginKH(NGUOIDUNG login)
        {
            string ten = login.TaiKhoan;
            string mk = login.MatKhau;
            NGUOIDUNG TK = db.NGUOIDUNGs.SingleOrDefault(n => n.TaiKhoan == ten && n.MatKhau == mk);
            if (TK != null)
            {
                Session["Login"] = login;
                return RedirectToAction("Index", "AdminChiNhanh");
            }
            return RedirectToAction("Index", "TrangChu");
        }

        public ActionResult dangxuat()
        {
            if ((Session["Login"] == null) || (Session["Login"].ToString() == ""))
            {
                return RedirectToAction("Login");
            }
            Session["Login"] = null;
            return RedirectToAction("Index", "TrangChu");
        }
    }
}