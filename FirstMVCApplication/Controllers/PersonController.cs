﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApplication.Controllers
{
    public class PersonController : Controller
    {
        public string Index()
        {
            return "Hello from Person controller index method";
        }
    }
}