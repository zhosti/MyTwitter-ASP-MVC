﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTwitter.App.Controllers
{
    public class NotificationController : BaseController
    {
        // GET: Notification
        public ActionResult Index()
        {
            return View();
        }
    }
}