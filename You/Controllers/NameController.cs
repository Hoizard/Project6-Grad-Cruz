using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using You.Models;

namespace You.Controllers
{
    public class NameController : Controller
    {
        // GET: Name
        public ActionResult Index()
        {
            List<string> list = new List<string>
            {
                "Erick",
                "Joe",
                "Robert"
            };

            ViewBag.Message = "My test view";
            ViewBag.Names = list;

            return View();
        }

        public ActionResult List()
        {
            List<Name> personList = new List<Name>
            {
                new Name() { FirstName = "Erick", Lastname = "Cruz" },
                new Name() { FirstName = "Joe", Lastname = "Carl" },
                new Name() { FirstName = "Frank", Lastname = "Ocean" }
            };

            ViewBag.Message = "Hard coded typing here";

            return View(personList);
        }

        public ActionResult CreatePerson()
        {
            return View();
        }

        public ActionResult RazorCodeExample()
        {
            return View();
        }
    }
}