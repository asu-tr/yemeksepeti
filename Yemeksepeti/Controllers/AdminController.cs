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
        // FIRMA EKLE EKLE

        // FIRMA DUZENLE SAYFASI EKLE

        // FIRMA SIL SAYFASI EKLE

        
        
        public ActionResult Urunler()
        {
            

            return View(Context.Baglanti.UrunTablosu.ToList());
        }
        

        //underconstruction
        public ActionResult UrunEkle()
        {
            ViewBag.Kategoriler = Context.Baglanti.Categories.ToList();

            return View();
        }

        [HttpPost]
        public ActionResult UrunEkle(Products urun)
        {
            m.Products.Add(urun);
            m.SaveChanges();

            return RedirectToAction("Urunler");
        }

        // URUN DUZENLE SAYFASI EKLE

        // URUN SIL SAYFASI EKLE

        
        
        public ActionResult Menuler()
        {
            return View(Context.Baglanti.MenuTablosu.ToList());
        }
        // MENU EKLE EKLE

        // MENU DUZENLE SAYFASI EKLE

        // MENU SIL SAYFASI EKLE

        
        
        public ActionResult Siparisler()
        {
            return View(Context.Baglanti.SiparisTablosu.ToList());
        }
        // SIPARIS DUZENLE SAYFASI EKLE

        
        
        public ActionResult Uyeler()
        {
            return View(Context.Baglanti.Users.ToList());
        }
        // UYE EKLE SAYFASI EKLE

        // UYE DUZENLE SAYFASI EKLE

        // UYE SIL SAYFASI EKLE

        
        
        public ActionResult Yorumlar()
        {
            return View(Context.Baglanti.YorumTablosu.ToList());
        }
        // yorum DUZENLE SAYFASI EKLE

        // yorum SIL SAYFASI EKLE



        public ActionResult Konumlar()
        {
            return View(Context.Baglanti.Locations.ToList());
        }
        // KONUM EKLE SAYFASI EKLE

        // KONUM DUZENLE SAYFASI EKLE

        // KONUM SIL SAYFASI EKLE


        public ActionResult CikisYap()
        {
            return View();
        }

    }
}