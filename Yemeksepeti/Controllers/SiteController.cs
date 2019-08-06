using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.App_Classes;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    [Authorize]
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
       /* public PartialViewResult Restoranlar()
        {
            var data = Context.Baglanti.Users.ToList();
            return PartialView(data);
        }*/

        public void SepeteEkle(int id)
        {
            SepetItem si = new SepetItem();
            Products u = Context.Baglanti.Products.FirstOrDefault(x => x.ProductID == id);

            si.Urun = u;
            si.Adet = 1;
            Sepet s = new Sepet();
            s.SepeteEkle(si);
        }
    }
}