using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MyTwitter.Model;

namespace MyTwitter.App.Models
{
    public class TweetViewModel
    {
        public string UserName { get; set; }

        public string Message { get; set; }

        public static Expression<Func<Tweet, TweetViewModel>> Create
        {
            get
            {
                return r => new TweetViewModel()
                {
                    UserName = r.User.UserName,
                    Message = r.Message
                };
            }
        }
    }
}