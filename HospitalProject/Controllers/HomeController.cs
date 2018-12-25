using HospitalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
          
            return View();
        }
        public ActionResult Test()
        {

            return View();
        }
        public ActionResult Activate()
        {

            return View();
        }
       
        public ActionResult WaitList()
        {

            var s = db.PatientHagzs.OrderBy(a => a.KashfDate).Where(a=>a.IsBaid ==true && a.EndTurn ==false);
            return View(s.ToList());
        }

        public ActionResult About()
        {
          

            return View();
        }
        public ActionResult Search(string searchName)
        {
            var result2 = db.HospitalInfoes.FirstOrDefault();
            ViewBag.Name = result2.Name;
            ViewBag.Adress = result2.Address;
            ViewBag.DoctorName = result2.DoctorName;
            ViewBag.Mobile = result2.ContactMobile;
            ViewBag.Phone = result2.ContactPhone;
            
            var result = db.PatientHagzs.Where(a => a.Name==(searchName)
            || a.Number==(searchName)
           ||a.Id.ToString()== searchName
             || a.Age.ToString ()==(searchName)
            ).ToList();
          
           


            return View(result);
        }
    
        public ActionResult Search2(DateTime searchName2 , DateTime searchName3)
        {
           
            var result = db.HesabatIns.Where(a => a.DateOfpay > searchName2 && a.DateOfpay <searchName3 );

            return View(result);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}