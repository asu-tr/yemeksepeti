using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    
    using App_Classes;
    using System.Web.Security;

    [Authorize]
    public class HomeController : Controller
    {

        Model_YS m = new Model_YS();


        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult Login(Kullanici k, string Hatirla)
        {
            bool sonuc = Membership.ValidateUser(k.KullaniciAdi, k.Sifre);

            if (sonuc)
            {
                if (Hatirla == "on")
                {
                    FormsAuthentication.RedirectFromLoginPage(k.KullaniciAdi, true);
                }
                else
                    FormsAuthentication.RedirectFromLoginPage(k.KullaniciAdi, false);

                return RedirectToAction("Restoranlar", "Site");
            }

            else
            {
                ViewBag.Mesaj = "Kullanıcı adı veya parola hatalı!";
                return View();
            }
            
        }


        [Authorize]
        public ActionResult CreateAccount()
        {

            List<Locations> loc = m.Locations.ToList();
            ViewBag.Locations = loc;
            
            return View();
        }



        [Authorize]
        public PartialViewResult Sepet()
        {
            return PartialView();
        }


        //sifremiunuttumeklde
    }
}