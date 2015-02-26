using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication33.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetJson()
        {
            return Json(new {foo = "bar"}, JsonRequestBehavior.AllowGet);
        }

    }
}
