using e_bilet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace e_bilet.Controllers
{
    public class RegisterController : Controller
    {
        EFEbiletDBEntities2 db = new EFEbiletDBEntities2();
        // GET: Register
        public ActionResult Index()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Signup(tblKisi kisi)
        {
            db.tblKisi.Add(kisi);
            int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                ViewBag.Result = "Kişi Başarıyla Eklenmiştir!";
                ViewBag.Status = "success";
                return RedirectToAction("Anasayfa", "Home");
            }
            else
            {
                ViewBag.Result = "Kişi Eklenememiştir";
                ViewBag.Status = "danger";
                return View();
            }
        }
    }
}