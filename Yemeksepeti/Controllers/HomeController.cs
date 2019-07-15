using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    public class HomeController : Controller
    {
        Model_YS m = new Model_YS();

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {

            List<Locations> loc = m.Locations.ToList();
            ViewBag.Locations = loc;


            

            return View();




        }
    }
}