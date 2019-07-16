using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Yemeksepeti.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Firmalar()
        {
            return View();
        }

        public ActionResult Siparisler()
        {
            return View();
        }

        public ActionResult Uyeler()
        {
            return View();
        }
    }
}