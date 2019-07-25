using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yemeksepeti.Models;

namespace Yemeksepeti.App_Classes
{
    public class Sepet
    {

        public static Sepet AktifSepet
        {

            get
            {
                HttpContext ctx = HttpContext.Current;
                if (ctx.Session["AktifSepet"] == null)
                    ctx.Session["AktifSepet"] = new Sepet();

                return (Sepet)ctx.Session["AktifSepet"];
            }
        }

        private List<SepetItem> urunler = new List<SepetItem>();

        public List<SepetItem> Urunler
        {
            get
            {
                return urunler;
            }
            set
            {
                urunler = value;
            }
        }
        public void SepeteEkle(SepetItem si)
        {
            if (Urunler.Any(x => x.Urun.ProductID == si.Urun.ProductID))
                Urunler.FirstOrDefault(x => x.Urun.ProductID == si.Urun.ProductID).Adet++;

            else
                Urunler.Add(si);
        }

        public decimal ToplamTutar
        {
            get
            {
                return Urunler.Sum(x => x.Tutar);
            }
        }
    }




    public class SepetItem
    {
        public Products Urun { get; set; }
        public ServedProducts UrunDetay { get; set; }
        public int Adet { get; set; }
        public decimal Tutar
        {
            get
            {
                return UrunDetay.Price * Adet;
            }
        }
    }
}