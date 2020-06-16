using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Clinic_Management_website.Models;
using Clinic_Management_website.Database;

namespace Clinic_Management_website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Patient p = Session["user"];
            return View(p);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}