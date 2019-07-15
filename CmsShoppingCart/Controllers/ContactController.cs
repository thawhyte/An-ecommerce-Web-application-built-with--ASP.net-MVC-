using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CmsShoppingCart.Models.Data;

namespace CmsShoppingCart.Controllers
{
    public class ContactController : Controller
    {
        private Db db = new Db();

        // GET: ContactDTOes
        public ActionResult Index()
        {
            return RedirectToAction("Contact");
        }
        

        // GET: ContactDTOes/Create
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Email,Message")] ContactDTO contactDTO)
        {
            if (ModelState.IsValid)
            {
                // Set TempData message
                TempData["SM"] = "Thank your for the message, you would be contacted soon!!!!!";

                //Refresh Page after showing the Tempdata message
                Response.AddHeader("Refresh", "2");

                db.Contact.Add(contactDTO);
                db.SaveChanges();
                return RedirectToAction("Create");
            }

            


            return View(contactDTO);
        }
        
    }
}
