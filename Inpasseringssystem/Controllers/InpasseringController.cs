﻿using Inpasseringssystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inpasseringssystem.Controllers
{
    public class InpasseringController : Controller
    {
        // GET: Inpassering
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult WhoToSee(guest model)
        {
            ViewBag.Name = model.Name;
            return View();
        }
    }
}