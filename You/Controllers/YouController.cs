using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using You.Models;

namespace You.Controllers
{
    public class YouController : Controller
    {

        public ActionResult Index()
        {
            List<string> list = new List<string>
            {
                "Erick",
                "Robert",
                "Vlad"
            };

            ViewBag.Message = "My test view";
            ViewBag.Names = list;

            return View();
        }

        public ActionResult List()
        {
            List<Name> nameList = new List<Name>
            {
                new Name() { FirstName = "Erick", Lastname = "Cruz" },
                new Name() { FirstName = "Robert", Lastname = "Brad" },
                new Name() { FirstName = "Vlad", Lastname = "King" }
            };

            ViewBag.Message = "Strong typing here";

            return View(nameList);
        }

        public ActionResult Create()
        {
            return View();
        }
    }
}
