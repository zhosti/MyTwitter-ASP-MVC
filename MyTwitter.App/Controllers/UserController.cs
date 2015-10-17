using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using MyTwitter.App.Models;
using MyTwitter.Model;

namespace MyTwitter.App.Controllers
{
    public class UserController : BaseController
    {
        [Authorize]
        public ActionResult UserProfile()
        {
            var user = this.Data.Users.GetById(this.User.Identity.GetUserId());
            var viewModel = new UserViewModel()
            {
                UserName = user.UserName
            };

            return this.View(viewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTweet(TweetBindinModel model)
        {
            if (model == null || !this.ModelState.IsValid)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest, "Invalid Data");
            }

            var tweet = new Tweet
            {
                Message = model.Message,
                TimeStamp = DateTime.Now,
                User = this.Data.Users.GetById(this.User.Identity.GetUserId())
            };

            this.Data.Tweets.Add(tweet);
            this.Data.Save();

            return this.RedirectToAction("Index", "Home");
        }
    }
}