using CmsShoppingCart.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CmsShoppingCart.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        // GET: Blog/Comment
        [HttpGet]
        public ActionResult Comment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Comment(BlogDTO blg)
        {
            using (Db db = new Db())
            {
                db.Blgdata.Add(blg);
                db.SaveChanges();
                string message = "SUCCESS";
                return Json(new { Message = message, JsonRequestBehavior.AllowGet });
            }
        }

        
        public JsonResult getComments()
        {
            using (Db db = new Db())
            {
                List<BlogDTO> users = new List<BlogDTO>();
                users = db.Blgdata.ToList();
                return Json(users, JsonRequestBehavior.AllowGet);
                // return View(students);
            }


        }
    }
}