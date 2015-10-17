using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using MyTwitter.Model;

namespace MyTwitter.App.Models
{
    public class UserViewModel
    {
        public string UserName { get; set; }

        public static Expression<Func<User, UserViewModel>> Create
        {
            get
            {
                return r => new UserViewModel()
                {
                    UserName = r.UserName,
                };
            }
        }
    }
}