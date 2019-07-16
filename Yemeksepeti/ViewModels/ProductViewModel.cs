using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yemeksepeti.Models;

namespace Yemeksepeti.ViewModels
{
    public class ProductViewModel
    {
        public List<Products> Urunler { get; set; }
        public List<Categories> Kategoriler { get; set; }
        public List<Users> Firmalar { get; set; }
    }
}