using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CmsShoppingCart.Models.Data;

namespace CmsShoppingCart.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        private Db db = new Db();

        // GET: Admin/ContactDTOes
        public ActionResult Index()
        {
            return View(db.Contact.ToList());
        }
        

        // GET: Admin/ContactDTOes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactDTO contactDTO = db.Contact.Find(id);
            if (contactDTO == null)
            {
                return HttpNotFound();
            }
            return View(contactDTO);
        }

        // POST: Admin/ContactDTOes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ContactDTO contactDTO = db.Contact.Find(id);
            db.Contact.Remove(contactDTO);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
