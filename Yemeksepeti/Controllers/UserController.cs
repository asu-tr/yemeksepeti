using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Yemeksepeti.App_Classes;
using Yemeksepeti.Models;

namespace Yemeksepeti.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        Model_YS m = new Model_YS();

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
                    mesaj += " Bu kullanıcı adı geçersiz.";
                    break;
                case MembershipCreateStatus.InvalidPassword:
                    mesaj += " Bu şifre uygun değil.";
                    break;
                case MembershipCreateStatus.InvalidQuestion:
                    mesaj += " Bu soru geçersiz.";
                    break;
                case MembershipCreateStatus.InvalidAnswer:
                    mesaj += " Bu cevap geçersiz.";
                    break;
                case MembershipCreateStatus.InvalidEmail:
                    mesaj += " Bu e-posta geçersiz.";
                    break;
                case MembershipCreateStatus.DuplicateUserName:
                    mesaj += " Bu kullanıcı adı zaten kullanılıyor.";
                    break;
                case MembershipCreateStatus.DuplicateEmail:
                    mesaj += " Bu e-posta zaten kullanılıyor.";
                    break;
                case MembershipCreateStatus.UserRejected:
                    mesaj += " Kullanıcı engel hatası.";
                    break;
                case MembershipCreateStatus.InvalidProviderUserKey:
                    mesaj += " Bu kullanıcı anahtarı geçersiz.";
                    break;
                case MembershipCreateStatus.DuplicateProviderUserKey:
                    mesaj += " Bu kullanıcı anahtarı zaten kullanılıyor.";
                    break;
                case MembershipCreateStatus.ProviderError:
                    mesaj += " Üye yönetimi sağlayıcısı hatası.";
                    break;
                default:
                    break;
            }

            ViewBag.Mesaj = mesaj;

            if (durum == MembershipCreateStatus.Success)
            {
                return RedirectToAction("Index");
            }

            else
                return View();
        }

        public ActionResult RolAta()
        {
            ViewBag.Roller = Roles.GetAllRoles().ToList();
            ViewBag.Kullanicilar = Membership.GetAllUsers();
            return View();
        }
        [HttpPost]
        public ActionResult RolAta(string KullaniciAdi, string RolAdi)
        {

            Roles.AddUserToRole(KullaniciAdi, RolAdi);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public string UyeRolleri(string kullaniciAdi)
        {
            List<string> roller = Roles.GetRolesForUser(kullaniciAdi).ToList();

            string rol = "";
            foreach (string r in roller)
            {
                rol += r + "-";

            }
            rol = rol.Remove(rol.Length - 1, 1);
            return rol;
        }


        //üyelerim aspnet tablosunda ama orayı yazamıyorum :/
        [HttpPost]
        public void Sil(int id)
        {
            Users user = m.Users.FirstOrDefault(x => x.UserID == id);
            m.Users.Remove(user);
            m.SaveChanges();
        }
    }
}