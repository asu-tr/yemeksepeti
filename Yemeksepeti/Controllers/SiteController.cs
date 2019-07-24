using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.App_Classes;

namespace Yemeksepeti.Controllers
{
    public class SiteController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // view ekle
        public ActionResult Profilim()
        {
            return View();
        }

        // view ekle
        public ActionResult Siparislerim()
        {
            return View();
        }

        //view ekle
        public ActionResult Yorumlarim()
        {
            return View();
        }

        //add view
        public ActionResult Kategoriler()
        {
            return View();
        }


        //add vew
        public PartialViewResult Restoranlar()
        {
            var data = Context.Baglanti.Users.ToList();
            return PartialView(data);
        }
    }
}