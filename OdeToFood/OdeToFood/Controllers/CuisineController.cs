using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Infrastructure;

namespace OdeToFood.Controllers
{
    //[Authorize]
    public class CuisineController : Controller
    {
        [HttpGet]
        public ActionResult Search(string name = "*" )
        {

            throw new Exception("00ps!");
            //if(name == "*")
            //{
            //    return Json(new { cuisineName = name }, JsonRequestBehavior.AllowGet);
            //    //return File(Server.MapPath("~/Content/Site.css"), "text/css");
            //    //return RedirectToRoute("Cuisine", new { name = "german" }); 
            //    //return RedirectToAction("Search", "Cuisine", new { name = "french" });
            //}

            name = Server.HtmlEncode(name);

            return Content(name);
        }

    }
}
