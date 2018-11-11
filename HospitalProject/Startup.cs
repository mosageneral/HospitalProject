using HospitalProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HospitalProject.Startup))]
namespace HospitalProject
{
    public partial class Startup
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRole();
            CreateUsers();
            CreateUsers2();
        }
        public void CreateUsers()
        {
            var usermanger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.Email = "admin@Pharmacita.com";
            user.UserName = "Doctor";
          



            var check = usermanger.Create(user, "123456789");
            if (check.Succeeded)
            {
                usermanger.AddToRole(user.Id, "Doctor");
            }
        }
        public void CreateUsers2()
        {
            var usermanger = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var user = new ApplicationUser();
            user.Email = "Nurse@Pharmacita.com";
            user.UserName = "Nurse";




            var check = usermanger.Create(user, "123456789");
            if (check.Succeeded)
            {
                usermanger.AddToRole(user.Id, "Nurse");
            }
        }
        public void CreateRole()
        {
            var rolemanger = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            IdentityRole role;
            if (!rolemanger.RoleExists("Doctor"))
            {
                role = new IdentityRole();
                role.Name = "Doctor";
                rolemanger.Create(role);

            }
            if (!rolemanger.RoleExists("Nurse"))
            {
                role = new IdentityRole();
                role.Name = "Nurse";
                rolemanger.Create(role);

            }

        }
    }
}
