using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StokWeb.Models.Entitiy;
using System.Web.Security;

namespace StokWeb.Controllers
{
    public class LoginController : Controller
    {
        StokTakipEntities1 db = new StokTakipEntities1();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(WebUser u)
        {

            var deger = db.WebUser.FirstOrDefault(x => x.UserName == u.UserName && x.Pass == u.Pass);

            if (deger!=null)
            {
                FormsAuthentication.SetAuthCookie(deger.UserName, false);
                return RedirectToAction("Index","Main");
            }
            else
            {
                
                return View();
            }
           
        }
    }
}