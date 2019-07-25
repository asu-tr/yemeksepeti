using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemeksepeti.App_Classes;

namespace Yemeksepeti.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            MembershipUserCollection users = Membership.GetAllUsers();
            return View(users);
        }

        public ActionResult Ekle()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Ekle(Kullanici k)
        {
            MembershipCreateStatus durum;
            Membership.CreateUser(k.KullaniciAdi, k.Sifre, k.Eposta, 
                k.GizliSoru, k.GizliCevap, true, out durum);

            string mesaj = "";

            switch (durum)
            {
                case MembershipCreateStatus.Success:
                    break;
                case MembershipCreateStatus.InvalidUserName:
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    mesaj += " Bu kullanıcı adı zaten kullanılıyor.";
                    break;
                case MembershipCreateStatus.DuplicateEmail:
                    break;
                case MembershipCreateStatus.UserRejected:
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    break;
                case MembershipCreateStatus.ProviderError:
                    break;
                default:
                    break;
            }
        }
    }
}