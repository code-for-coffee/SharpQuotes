using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SharpQuotes.Controllers
{
    public class QuoteController : Controller
    {
        public ActionResult Index()
        {
			// get quotes or make new list if none exist
			if (Session["quotesList"] == null)
			{
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
            return View ();
        }

        public ActionResult Details(int id)
        {
            return View ();
        }

        public ActionResult Create()
        {
            return View ();
        } 

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
        
        public ActionResult Edit(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        public ActionResult Delete(int id)
        {
            return View ();
        }

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}