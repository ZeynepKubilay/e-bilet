using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_bilet.Models;
using System.Data.Entity;
using e_bilet.Models.Managers;
using System.Web.Security;

namespace e_bilet.Controllers
{
    
    public class LoginController : Controller
    {
        //MyDbContext db = new MyDbContext();
        EFEbiletDBEntities2 db = new EFEbiletDBEntities2();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        //tblKisi kisi
        

        [HttpPost]
        public ActionResult Index(tblKisi kisi)
        { 

            var userInDb = db.tblKisi.FirstOrDefault(x => x.Ad == kisi.Ad && x.Sifre == kisi.Sifre);
            if(userInDb != null)
            {
                FormsAuthentication.SetAuthCookie(kisi.Ad, false);
                return RedirectToAction("Anasayfa", "Home");   
            }
            else
            {
                ViewBag.Mesaj = "Geçersiz Kullanıcı...";
                return View();
            }
            
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}