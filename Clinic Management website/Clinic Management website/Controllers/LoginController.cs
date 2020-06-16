using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Clinic_Management_website.Models;
using Clinic_Management_website.Database;


namespace Clinic_Management_website.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(loginUserPass model)
        {
            if (ModelState.IsValid)
            {
                using (ClinicMangementEntities db_User = new ClinicMangementEntities())
                {
                    try
                    {
                        var user = db_User.Patients.Where(u => u.lname == model.userName && u.NCode == model.password).FirstOrDefault();
                        if(user != null)
                        {
                            Session["message"] = "شما با موفقیت وارد شدید";
                            Session["user"] = user;
                            return RedirectToAction("Index", "Home");
                        }
                    }
                    catch(Exception)
                    {
                        return RedirectToAction("Index" , "Login");
                    }
                }
            }
            return RedirectToAction("Index", "Login");
        }
    }
}