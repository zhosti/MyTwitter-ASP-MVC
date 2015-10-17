using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MyTwitter.Model;

namespace MyTwitter.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(MyTwitter.Data.ApplicationDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == "Administrator"))
            {
                var roleStore = new RoleStore<IdentityRole>(context);
                var roleManager = new RoleManager<IdentityRole>(roleStore);
                var role = new IdentityRole { Name = "Administrator" };

                roleManager.Create(role);
            }

            // if user doesn't exist, create one and add it to the admin role
            if (!context.Users.Any(u => u.UserName == "admin@admin.com"))
            {
                var userStore = new UserStore<User>(context);
                var userManager = new UserManager<User>(userStore);
                var user = new User { UserName = "admin@admin.com", Email = "admin@admin.com" };

                userManager.Create(user, "password");
                userManager.AddToRole(user.Id, "Administrator");
            }

            base.Seed(context);
        }
    }
}
