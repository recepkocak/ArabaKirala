using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arabakirala.Controllers
{
    public class AdminController : Controller
    {

        public ActionResult YoneticiPanel()
        {
            return View();
        }
        // GET: Admin
        public ActionResult FirmaEkle()
        {
            return View();
        }


        public ActionResult AracEkle()
        {
            return View();
        }

        public ActionResult FiyatEkle()
        {
            return View();
        }
    }
}