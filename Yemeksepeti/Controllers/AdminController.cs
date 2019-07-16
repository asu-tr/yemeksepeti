using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.App_Classes;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    public class AdminController : Controller
    {

        Model_YS m = new Model_YS();

        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Firmalar()
        {
            return View(Context.Baglanti.Users.ToList());
        }
        //FIRMA EKLE EKLE


        public ActionResult Urunler()
        {
            return View();
        }

        public ActionResult Menuler()
        {
            return View();
        }

        public ActionResult Siparisler()
        {
            return View();
        }

        public ActionResult Uyeler()
        {
            return View(Context.Baglanti.Users.ToList());
        }

        // UYE EKLE SAYFASI EKLE

        // UYE DUZENLE SAYFASI EKLE

        // UYE SIL SAYFASI EKLE

        public ActionResult Yorumlar()
        {
            return View();
        }

        public ActionResult Konumlar()
        {
            return View();
        }

        public ActionResult CikisYap()
        {
            return View();
        }



    }
}