using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.App_Classes;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {

        Model_YS m = new Model_YS();
        

     
        

        //ÜRÜNLER
        public ActionResult Urunler()
        {
            

            return View(Context.Baglanti.UrunTablosu.ToList());
        }
        
        

       

        
        // MENÜLER
        public ActionResult Menuler()
        {
            return View(Context.Baglanti.MenuTablosu.ToList());
        }

        
        // SİPARİŞLER
        public ActionResult Siparisler()
        {
            return View(Context.Baglanti.SiparisTablosu.ToList());
        }

        
        // ÜYELER
        public ActionResult Uyeler()
        {
            return View(Context.Baglanti.Users.ToList());
        }

        
        // YORUMLAR
        public ActionResult Yorumlar()
        {
            return View(Context.Baglanti.YorumTablosu.ToList());
        }


        // KONUMLAR
        public ActionResult Konumlar()
        {
            return View(Context.Baglanti.Locations.ToList());
        }
        // KONUM EKLE
        public ActionResult KonumEkle()
        {
            return View(Context.Baglanti.Sehirler.ToList());
        }
        [HttpPost]
        public ActionResult KonumEkle(Locations konum)
        {
            m.Locations.Add(konum);
            m.SaveChanges();

            return RedirectToAction("Konumlar");
        }
        

            

    }
}