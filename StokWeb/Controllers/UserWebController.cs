using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokWeb.Models.Entitiy;

namespace StokWeb.Controllers
{
    public class UserWebController : Controller
    {
        StokTakipEntities1 db = new StokTakipEntities1();
        public ActionResult Index()
        {
            var list = db.WebUser.ToList();
            return View(list);
        }
        [HttpPost]
        public ActionResult Ekle(WebUser s)
        {
            db.WebUser.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Ekle()
        {

            return View();
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var usr = db.WebUser.Find(id);
            return View(usr);
        }
        [HttpPost]
        public ActionResult Guncelle(WebUser s)
        {
            var stok = db.WebUser.Find(s.Id);
            stok.UserName = s.UserName;
            stok.Name = s.Name;
            stok.Surname = s.Surname;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var usr = db.WebUser.Find(id);
            db.WebUser.Remove(usr);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}