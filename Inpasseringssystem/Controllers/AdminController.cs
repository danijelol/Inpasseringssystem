using Inpasseringssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inpasseringssystem.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AdminStart(Guest model)
        {
            if (model.Password != "password")
            {
                ViewBag.Error = "Felaktigt lösenord!";
                return View("Index");
            }
            return View();
        }
    }
}