using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTwitter.App.Controllers
{
    public class TweetController : BaseController
    {
        // GET: Tweet
        public ActionResult Index()
        {
            return View();
        }
    }
}