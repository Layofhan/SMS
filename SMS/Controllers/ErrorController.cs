﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMS.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        [AllowAnonymousAttribute]
        public ActionResult NoAuthority()
        {
            return View();
        }
    }
}