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
            ViewBag.Name = model.Name;
            return View();
        }
    }
}