using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataSoft.Controllers
{
    public class MyTemplateController : Controller
    {
        // GET: MyTemplate
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View("Contact");
        }

        public ActionResult About()
        {
            return View("About");
        }
    }
}