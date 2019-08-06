using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    
    using App_Classes;
    using System.Web.Security;

    [Authorize]
    public class HomeController : Controller
    {

        Model_YS m = new Model_YS();



        



        [Authorize]
        public PartialViewResult Sepet()
        {
            return PartialView();
        }

        


        
    }
}