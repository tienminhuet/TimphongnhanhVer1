using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About";

            return View();
        }
        public ActionResult Listings()
        {
            ViewBag.Message = "Listing";

            return View();
        }
        public ActionResult News()
        {
            ViewBag.Message = "News";

            return View();
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Contact";

            return View();
        }
        public ActionResult Assignment()
        {
            ViewBag.Message = "Assignment";

            return View();
        }

        public ActionResult Viewroom()
        {
            ViewBag.Message = "Viewroom";

            return View();
        }


    }
}