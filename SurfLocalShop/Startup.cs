using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using Owin;
using SurfLocalShop.Models;
using System;
using System.Web;

[assembly: OwinStartupAttribute(typeof(SurfLocalShop.Startup))]
namespace SurfLocalShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }

        // In this method we will create default User roles and Admin user for login    
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            const string name = "admin@surflocal.com";
            const string password = "Password1";
            const string roleName = "Admin";

            //Create Role Admin if it does not exist
            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new IdentityRole(roleName);
                var roleresult = roleManager.Create(role);
            }

            var user = userManager.FindByName(name);
            if (user == null)
            {
                user = new ApplicationUser
                {
                    UserName = name,
                    Email = name,
                    FirstName = "Admin",
                    LastName = "Admin",
                    DateOfBirth = new DateTime(2015, 1, 1),
                    Address = new Address
                    {
                        AddressLine1 = "1 Admin Street",
                        Town = "Town",
                        County = "County",
                        Postcode = "PostCode"
                    }
                };
                var result = userManager.Create(user, password);
                result = userManager.SetLockoutEnabled(user.Id, false);
            }

            // Add user admin to Role Admin if not already added
            var rolesForUser = userManager.GetRoles(user.Id);
            if (!rolesForUser.Contains(role.Name))
            {
                var result = userManager.AddToRole(user.Id, role.Name);
            }
            //Create users role
            const string userRoleName = "Users";
            role = roleManager.FindByName(userRoleName);
            if (role == null)
            {
                role = new IdentityRole(userRoleName);
                var roleresult = roleManager.Create(role);
            }
        }
    }
}
