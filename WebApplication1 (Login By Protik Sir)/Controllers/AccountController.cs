using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string btnSubmit, string txtUserName, string txtPassword)
        {
            string LoginMsg = "";
            if (btnSubmit == "LogIn")
            {
                if(txtUserName == "Nafi" && txtPassword == "123456")
                {
                    Session["User"] = "Nafi";
                    return RedirectToAction("Dashboard", "Home");
                }
                else
                {
                    LoginMsg = "Failed, UserName/Password Did Not Match";
                }
                 
            }
            else if (btnSubmit == "Forget Password")
            {
                return RedirectToAction("forget", "Account");
            }
            ViewBag.LoginMsg = LoginMsg;
            return View();
        }
        [HttpPost]
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Login", "Account");
        }
       
    }
}