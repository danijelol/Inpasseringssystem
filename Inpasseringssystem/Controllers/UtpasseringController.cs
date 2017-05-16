using Inpasseringssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inpasseringssystem.Controllers
{
    public class UtpasseringController : Controller
    {
        // GET: Utpassering
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Complete(Guest model)
        {
            if (model.Name == null && model.Surname == null)
            {
                ViewBag.ErrorName = "Du måste ange ditt förnamn";
                ViewBag.ErrorSurname = "Du måste ange ditt efternamn";
                return View("Index");
            }
            else if (model.Name == null)
            {
                ViewBag.ErrorName = "Du måste ange ditt förnamn";
                return View("Index");
            }
            else if (model.Surname == null)
            {
                ViewBag.ErrorSurname = "Du måste ange ditt efternamn";
                return View("Index");
            }

            ViewBag.Name = model.Name;
            return View();
        }
    }
}