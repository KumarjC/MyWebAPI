﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebAPI.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Get()
        {
            return "Hello World";
        }

    }
}