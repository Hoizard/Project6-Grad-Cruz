using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace You.Controllers
{
    public class YouController : Controller
    {
        // GET: You
        public ActionResult Index()
        {
            List<string> list = new List<string>
            {
                "Erick",
                "Cruz",
                "ITMD-563"
            };

            ViewBag.Message = "My Test View";
            ViewBag.Names = list;
            return View();
        }
    }
}