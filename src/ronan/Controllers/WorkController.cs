﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace ronan.Controllers
{
    public class WorkController : Controller
    {
        public ActionResult Index()
        {
            return View("Work");
        }
    }
}
