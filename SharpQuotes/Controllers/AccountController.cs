using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharpQuotes.Controllers
{
    public class AccountController : Controller
    {
        public ActionResult Register()
        {
			// display the Registration form
            return View("registerGet");
        }
		[HttpPost]
		public ActionResult Register(string username, string email, string password)
		{
			// instantiate new user model
			var model = new User(username, email, password);
			// set session variables (auto-login); change for production (demo purposes only!)
			// no database is attached so we store the created User in Sessionn
			Session["user"] = model;
			// pass the model off to the view for registration confirmation
			return View("registerPost");
		}
		public ActionResult Login()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Login(string email, string password)
		{
			// login via emaill
			var model = (User)Session["user"];
			if (model.comparePassword(password) == true)
			{
				// display success view
				return View("loginSuccess");
			}
			// display invalid view
			return View("loginFailure");
		}
		public ActionResult Logout()
		{
			// clear session
			Session["user"] = null;
			return View();
		}
    }
}
