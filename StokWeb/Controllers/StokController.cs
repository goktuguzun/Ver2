using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using StokWeb.Models.Entitiy;
namespace StokWeb.Controllers
{
    public class StokController : Controller
    {
        // GET: Stok


        StokTakipEntities1 db = new StokTakipEntities1();
        public ActionResult Index()
        {
            var degerler = db.StokGirisCikis.ToList();

            return View(degerler);
        }
        [HttpPost]
        public ActionResult StokGirisCikisEkle(StokGirisCikis s)
        {
            db.StokGirisCikis.Add(s);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult StokGirisCikisEkle()
        {
            return View();
        }


        [HttpGet]
        public ActionResult StokGuncelle(int id)
        {
            var stok = db.StokGirisCikis.Find(id);
            return View("StokGuncelle", stok);
        }

        [HttpPost]
        public ActionResult StokGuncelle(StokGirisCikis s)
        {
            var stok = db.StokGirisCikis.Find(s.Id);
            stok.StokKod = s.StokKod;
            stok.StokAd = s.StokAd;
            stok.Aciklama = s.Aciklama;
            stok.Tarih = s.Tarih;
            stok.Sicil = s.Sicil;
            stok.Adet = s.Adet;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult StokSil(int id)
        {
            var stok = db.StokGirisCikis.Find(id);
            db.StokGirisCikis.Remove(stok);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult StokGiris()
        {
            return View();
        }


        [HttpPost]
        public ActionResult StokGiris(StokTabloSatici s)
        {

            var stok = db.StokTabloSatici.Find(s.Id);
            stok.KalanMiktar = s.KalanMiktar;
            stok.KritikStok = s.KritikStok;
            stok.StokAdi = s.StokAdi;
            stok.StokKodu = s.StokKodu;
            db.SaveChanges();
            return View();
        }

        [HttpPost]
        public ActionResult YeniStokGiris(StokTabloSatici s)
        {
            db.StokTabloSatici.Add(s);
            db.SaveChanges();
            return View();
        }
        [HttpGet]
        public ActionResult YeniStokGiris()
        {

            return View();
        }


        public ActionResult YeniStokGiris(StokTabloSatici s)
        {
            var stok = db.StokTabloSatici.Find(s.Id);
            stok.KalanMiktar = s.KalanMiktar;
            stok.KritikStok = s.KritikStok;
            stok.StokAdi = s.StokAdi;
            stok.StokKodu = s.StokKodu;
            db.SaveChanges();
            return View();
        }
        public ActionResult MevcutStokGuncelle(int id)
        {
            var stok = db.StokTabloSatici.Find(id);


        }
    }
}