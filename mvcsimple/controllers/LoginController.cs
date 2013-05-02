using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcSimple.Models;
using WebMatrix.WebData;

namespace MvcSimple.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index()
        {
            Models.LoginModel objlm = new LoginModel();
            return View(objlm);
        }

        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Index(LoginModel model, string returnUrl)
        {
            if (ModelState.IsValid && WebSecurity.Login(model.UserName, model.Password, persistCookie: model.RememberMe))
            {
                return RedirectToLocal(returnUrl);
            }

            // If we got this far, something failed, redisplay form
            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }


        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Default","Index");
            }
        }

       [AllowAnonymous]
        public ActionResult Logout()
        {
            WebSecurity.Logout();
           return RedirectToAction("Index", "Default");
        }
    }
}
