﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Permit.PublicPortal.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        //[Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}