using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.Models;

namespace Yemeksepeti.ViewModel
{
    public class CityDistinctID
    {
        public IEnumerable<SelectListItem> IDler { get; set; }
        public int SecilenID { get; set; }

        public IEnumerable<SelectListItem> Sehirler { get; set; }
        public int SecilenSehir { get; set; }

        public IEnumerable<SelectListItem> Semtler { get; set; }
        public int SelectedSemt { get; set; }

        public void KonumIDBulma()
        {
            IDler = new List<SelectListItem>();
            Sehirler = new List<SelectListItem>();
            Semtler = new List<SelectListItem>();
        }


    }
}