using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokWeb.Models.Entitiy;
namespace StokWeb.Controllers
{
    public class ServisController : Controller
    {
        // GET: Servis
        StokTakipEntities1 db = new StokTakipEntities1();
        public ActionResult Index()
        {
            var degerler = db.Servis.ToList();
            return View(degerler);
        }


        public ActionResult ServisSil(int id)
        {
            var stok = db.Servis.Find(id);
            db.Servis.Remove(stok);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Servis s)
        {
            db.Servis.Add(s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Guncelle(int id)
        {
            var ser = db.Servis.Find(id);
            return View(ser);
        }

        [HttpPost]
        public ActionResult Guncelle(Servis s)
        {
            var stok = db.Servis.Find(s.id);
            stok.SicilNo = s.SicilNo;
            stok.Durum = s.Durum;
            stok.TedenBolum = s.TedenBolum;
            stok.Arıza = s.Arıza;
            stok.Gittigitarih = s.Gittigitarih;
            stok.GeldigiTarih = s.GeldigiTarih;
            stok.GittigiServis = s.GittigiServis;
            stok.YapılanIslem = s.YapılanIslem;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}