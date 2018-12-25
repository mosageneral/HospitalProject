using HospitalProject.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System.Linq;
using System;

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
            createdata();
            createdata2();
            createdata3();
            createdata4();
            createdata5();
            createdata6();
            
           
        }

        private void createdata6()
        {
            var count = db.HospitalInfoes.Where(a => a.Name == "-").Count();


            if (count > 0)
            {

            }
            else
            {
                HospitalInfo hi = new HospitalInfo();
                hi.Address = "-";
                hi.ContactMobile = "0";
                hi.Contactmobile2 = "0";
                hi.ContactPhone = "0";
                hi.DoctorName = "-";
                hi.Id = 1;
                hi.Name = "-";
                db.HospitalInfoes.Add(hi);
                db.SaveChanges();
            }
            }

        public void createdata5()
        {
            var count = db.Adwyas.Where(a => a.Name == "-").Count();


            if (count > 0)
            {

            }
            else
            {
                Adwya ad = new Adwya();
                ad.Id = 1;
                ad.Name = "-";
                ad.Content0 = ".";
                db.Adwyas.Add(ad);
                db.SaveChanges();
            }
        }

        public void createdata4()
        {
            var count = db.Rays.Where(a => a.Name == "-").Count();


            if (count > 0)
            {

            }
            else
            {
                Ray ray = new Ray();
                ray.Id = 1;
                ray.Name = "-";
                db.Rays.Add(ray);
                db.SaveChanges();
            }
            
        }

        public void createdata3()
        {
            var count = db.Tamen.Where(a => a.Name == "-").Count();


            if (count > 0)
            {

            }
            else
            {
                Tamen tamen = new Tamen();
                tamen.Id = 1;
                tamen.Name = "-";
                tamen.PhoneNumber = "0";
                tamen.Price = 0;
                tamen.WebSite = "http://none.com";
                tamen.Email = "none@none.com";
                tamen.Agent = "-";
                tamen.Address = "-";
                db.Tamen.Add(tamen);
                db.SaveChanges();
            }
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
       public void createdata()
        {
            var count = db.Tahlels.Where(a => a.Name == "-").Count();
            
           
            if (count>0)
            {
                
            }
            else
            {
                Tahlel t = new Models.Tahlel();
                t.Id = 1;
                t.Name = "-";
                t.Price = 0;
                db.Tahlels.Add(t);
                db.SaveChanges();
            }
           
           
        }
        public void createdata2()
        {
            var count = db.Marads.Where(a => a.Name == "-").Count();


            if (count > 0)
            {

            }
            else
            {
                Marad m = new Models.Marad();
                m.Id = 1;
               m.Name = "-";
                m.Price = 0;
                
                db.Marads.Add(m);
                db.SaveChanges();
            }


        }
    }
}
