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
            Patient p = (Patient)Session["user"];
            ViewBag.message = (String)Session["message"];
            using (ClinicMangementEntities db_User = new ClinicMangementEntities())
            {
                try
                {
                    var visit = db_User.Visits.Where(u => u.PatientId == p.id).FirstOrDefault();
                    if (visit != null)
                    {
                        ViewBag.date = visit.Date.ToString();
                        return View(p);
                    }
                }
                catch(Exception)
                {

                }
            }
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