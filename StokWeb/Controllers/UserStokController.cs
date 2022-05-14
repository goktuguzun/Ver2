using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokWeb.Models.Entitiy;

namespace StokWeb.Controllers
{
    public class UserStokController : Controller
    {
        StokTakipEntities1 db = new StokTakipEntities1();
        public ActionResult Index()
        {
            var list = db.Kullanicilar.ToList();
            return View(list);
        }
        [HttpPost]
        public ActionResult Ekle(Kullanicilar s)
        {
            db.Kullanicilar.Add(s);
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
            var usr = db.Kullanicilar.Find(id);
            return View(usr);
        }
        [HttpPost]
        public ActionResult Guncelle(Kullanicilar s)
        {
            var stok = db.Kullanicilar.Find(s.SicilNo);
            stok.KullaniciTuru = s.KullaniciTuru;
            stok.Ad = s.Ad;
            stok.Soyad = s.Soyad;
            stok.SicilNo = s.SicilNo;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Sil(int id)
        {
            var usr = db.Kullanicilar.Find(id);
            db.Kullanicilar.Remove(usr);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}