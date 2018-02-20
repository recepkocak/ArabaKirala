using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arabakirala.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [Route("Araclar")]
        public ActionResult Araclar()
        {

            return View();
        }

        [Route("İletişim")]
        public ActionResult iletisim()
        {
            return View();
        }
    }
}