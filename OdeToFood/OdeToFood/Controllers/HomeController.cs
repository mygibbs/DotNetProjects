using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = string.Format("{0}::{1} {2}",
                                RouteData.Values["controller"],
                                RouteData.Values["action"],
                                RouteData.Values["id"]);

            var model = new RestaurantReview()
            {
                Name = "Tersiguel's",
                Rating = 9
            };

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Location = "Maryland, USA";
            return View();
        }
    }
}
