﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _4GWireline.Web.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Index()
        {
            return View("Index");
        }

    }
}
