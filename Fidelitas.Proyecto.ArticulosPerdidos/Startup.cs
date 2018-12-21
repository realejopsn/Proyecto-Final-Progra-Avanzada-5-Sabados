using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;
using System.Security.Claims;
using Fidelitas.Proyecto.ArticulosPerdidos.Model;
using Fidelitas.Proyecto.ArticulosPerdidos.Models;
using Microsoft.Owin;

[assembly: OwinStartupAttribute(typeof(Fidelitas.Proyecto.ArticulosPerdidos.Startup))]
namespace Fidelitas.Proyecto.ArticulosPerdidos
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
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


                // In Startup iam creating first Admin Role and creating a default Admin User 
                if (!roleManager.RoleExists("Admin"))
                {

                    // first we create Admin rol
                    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Admin";
                    roleManager.Create(role);
                //Here we create a Admin super user who will maintain the website				

                var user = new ApplicationUser();
                user.UserName = "Admin";
                user.Email = "Admin@gmail.com";

                string userPWD = "Admin123!!";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }

            }

                // creating Creating Manager role 
                if (!roleManager.RoleExists("Custodia"))
                {
                    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Custodia";
                    roleManager.Create(role);

                }
             
        

            // creating Creating Employee role 
            if (!roleManager.RoleExists("Invitado"))
                {
                    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                    role.Name = "Invitado";
                    roleManager.Create(role);

                }

           
        }
        }
    }
