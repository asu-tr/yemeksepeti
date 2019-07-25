using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Yemeksepeti.App_Classes
{
    public class Kullanici
    {
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }
        public string GizliSoru { get; set; }
        public string GizliCevap { get; set; }
    }
}