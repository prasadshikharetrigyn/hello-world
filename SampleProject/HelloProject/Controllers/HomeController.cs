using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Yourcontact page.";
            ViewBag.Message = "Your contact page.";
            ViewBag.Message = "Your contact page.";
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}