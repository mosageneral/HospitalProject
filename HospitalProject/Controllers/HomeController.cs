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
       
        public ActionResult WaitList()
        {

            var s = db.PatientHagzs.OrderBy(a => a.KashfDate).Where(a=>a.IsBaid ==true && a.EndTurn ==false);
            return View(s.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Search(string searchName)
        {
            var result = db.PatientHagzs.Where(a => a.Name==(searchName)
            || a.Number==(searchName)
           ||a.Id.ToString()== searchName
             || a.Age.ToString ()==(searchName)
             
            ).ToList();

            return View(result);
        }
        public ActionResult Search2(string searchName2)
        {
            var result = db.HesabatIns.Where(a => a.PatientName.Contains(searchName2)
          
            ).ToList();

            return View(result);
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}