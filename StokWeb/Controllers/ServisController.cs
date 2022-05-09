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
    }
}