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
    public class BlogController : Controller
    {
        private Db db = new Db();

        // GET: Admin/Blog
        public ActionResult Index()
        {
            return View(db.Blgdata.ToList());
        }

        // GET: Admin/Blog/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogDTO blogDTO = db.Blgdata.Find(id);
            if (blogDTO == null)
            {
                return HttpNotFound();
            }
            return View(blogDTO);
        }

        // GET: Admin/Blog/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogDTO blogDTO = db.Blgdata.Find(id);
            if (blogDTO == null)
            {
                return HttpNotFound();
            }
            return View(blogDTO);
        }

        // POST: Admin/Blog/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Name,Email,Comment")] BlogDTO blogDTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(blogDTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(blogDTO);
        }

        // GET: Admin/Blog/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BlogDTO blogDTO = db.Blgdata.Find(id);
            if (blogDTO == null)
            {
                return HttpNotFound();
            }
            return View(blogDTO);
        }

        // POST: Admin/Blog/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BlogDTO blogDTO = db.Blgdata.Find(id);
            db.Blgdata.Remove(blogDTO);
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
