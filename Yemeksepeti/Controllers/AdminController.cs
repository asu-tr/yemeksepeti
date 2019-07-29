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
    public class AdminController : Controller
    {

        Model_YS m = new Model_YS();
        
        // ANA SAYFA
        public ActionResult Index()
        {
            return View();
        }
        
        // FİRMALAR
        public ActionResult Firmalar()
        {
            return View(Context.Baglanti.Users.ToList());
        }








        // FIRMA EKLE EKLE

        // UNDER CONSTRUCTION
        public ActionResult FirmaEkle()
        {
            ViewBag.Sehirler = Context.Baglanti.Sehirler.ToList();

            return View();
        }
        [HttpPost]
        public ActionResult FirmaEkle(Users firma)
        {
            m.Users.Add(firma);
            m.SaveChanges();

            return RedirectToAction("Firmalar");
        }




        



        // FIRMA DUZENLE SAYFASI EKLE

        // FIRMA SIL SAYFASI EKLE


        //ÜRÜNLER
        public ActionResult Urunler()
        {
            

            return View(Context.Baglanti.UrunTablosu.ToList());
        }
        
        // ÜRÜN EKLE
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

        
        // MENÜLER
        public ActionResult Menuler()
        {
            return View(Context.Baglanti.MenuTablosu.ToList());
        }
        // MENU EKLE EKLE AMA MENU HAS TO HAVE A MENUCONTENT SO IM NOT SURE ABOUT HOW TO DO THAT

        // MENU DUZENLE SAYFASI EKLE

        // MENU SIL SAYFASI EKLE

        
        // SİPARİŞLER
        public ActionResult Siparisler()
        {
            return View(Context.Baglanti.SiparisTablosu.ToList());
        }
        // SIPARIS DUZENLE SAYFASI EKLE

        
        // ÜYELER
        public ActionResult Uyeler()
        {
            return View(Context.Baglanti.Users.ToList());
        }
        // UYE EKLE SAYFASI EKLE

        // UYE DUZENLE SAYFASI EKLE

        // UYE SIL SAYFASI EKLE

        
        // YORUMLAR
        public ActionResult Yorumlar()
        {
            return View(Context.Baglanti.YorumTablosu.ToList());
        }
        // yorum DUZENLE SAYFASI EKLE

        // yorum SIL SAYFASI EKLE


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

        


        // KONUM DUZENLE SAYFASI EKLE

        // KONUM SIL SAYFASI EKLE


        public ActionResult CikisYap()
        {
            return View();
        }

    }
}