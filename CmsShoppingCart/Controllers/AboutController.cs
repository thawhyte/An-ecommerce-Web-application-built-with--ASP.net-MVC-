using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CmsShoppingCart.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Index()
        {
            return RedirectToAction("About");
        }


        // GET: About/About-us
        public ActionResult About()
        {
            return View();
        }
    }
}