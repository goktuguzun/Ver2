using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokWeb.Models.Entitiy;


namespace StokWeb.Controllers
{
    public class WebUserController : Controller
    {
        StokTakipEntities1 db = new StokTakipEntities1();
        public ActionResult Index()
        {
            var kullanici = db.WebUser.ToList();
            return View(kullanici);
        }
    }
}