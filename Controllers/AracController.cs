using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace arabakirala.Controllers
{
    public class AracController : Controller
    {
        // GET: Arac
        [Route("AracDetay")]
        public ActionResult AracDetay()
        {
            return View();
        }
    }
}