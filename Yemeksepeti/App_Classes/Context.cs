using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Yemeksepeti.Models;

namespace Yemeksepeti.App_Classes
{
    public class Context
    {
        private static Model_YS baglanti;

        public static Model_YS Baglanti
        {
            get
            {
                if (baglanti == null)
                    baglanti = new Model_YS();
                return baglanti;
            }
            set { baglanti = value; }
        }

    }
}