using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class NhmHomeController : Controller
    {
        public ActionResult NhmIndex()
        {
            return View();
        }

        public ActionResult NhmAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NhmContact()
        {
            ViewBag.msv = "2210900044";
            ViewBag.fullname = "Ngohoangminhz";


            return View();
        }
    }
}