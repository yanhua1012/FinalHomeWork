using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FinalHomeWork.ViewModels;

namespace FinalHomeWork.Controllers
{
    public class HomeController : Controller
    {
        protected Dictionary<string, string> fakeUserDictionary = new Dictionary<string, string> { { "admin@mvc.com", "1234" }, { "user@mvc.com", "1234" } };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (fakeUserDictionary.ContainsKey(model.Account))
                {
                    if (model.Password == fakeUserDictionary[model.Account])
                    {
                        //ProcessLogin(model);
                        //return RedirectToAction("Index");
                        this.ViewData["IsLogin"] = true;
                        return View("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "請輸入正確的帳號密碼");

            }

            return View();
        }
    }
}