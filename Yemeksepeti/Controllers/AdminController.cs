using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.App_Classes;
using Yemeksepeti.Models;
using Yemeksepeti.ViewModels;

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
            var Urun = new List<Products>();
            var Kategori = new List<Categories>();
            var Firma = new List<Users>();

            var UrunViewModel = new ProductViewModel
            {
                Urunler = Urun,
                Kategoriler = Kategori,
                Firmalar = Firma
            };

            return View(UrunViewModel);
        }
        // URUN EKLE EKLE

        // URUN DUZENLE SAYFASI EKLE

        // URUN SIL SAYFASI EKLE

        
        
        public ActionResult Menuler()
        {
            return View(Context.Baglanti.Menus.ToList());
        }
        // MENU EKLE EKLE

        // MENU DUZENLE SAYFASI EKLE

        // MENU SIL SAYFASI EKLE

        
        
        public ActionResult Siparisler()
        {
            return View(Context.Baglanti.Orders.ToList());
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
            return View(Context.Baglanti.Comments.ToList());
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