using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace SharpQuotes.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var mvcName = typeof(Controller).Assembly.GetName();
			var isMono = Type.GetType("Mono.Runtime") != null;

			ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
			ViewData["Runtime"] = isMono ? "Mono" : ".NET";

			// get quotes or make new list if none exist
			if (Session["quotesList"] == null) {
				Session["quotesList"] = new List<Quote>();
			}

			// grab item since Session will not allow you to add directly
			// to subchild
			var temp = (List<Quote>)Session["quotesList"];
			// add
			temp.Add(
				new Quote("Lambchop", "And it goes on and on my friend")
			);
			// set back to session
			Session["quotesList"] = temp;
			return View();
		}
	}
}

