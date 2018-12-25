using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalProject.Models;

namespace HospitalProject.Controllers
{
    public class ActivatesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Activates
        public ActionResult Index()
        {
          var checkthere = db.Activates.Where(a => a.id > 0);
            var enddate = db.Activates.FirstOrDefault();
             var mosa =   checkthere.Count();
            if (mosa==1)
            {

                ViewBag.status = "(اذا كان هناك مشكلة الرجاء الإتصال بالدعم الفني) "+enddate.EndDate.ToShortDateString() + "(التطبيق قد تم تفعيله مسبقا يتنهي في)";

                return View();
            }
            else
            {
                var activate = new Activate();
                activate.DateNow = DateTime.Now;
                activate.EndDate = DateTime.Now.AddYears(1);
                activate.Activated = true;
                db.Activates.Add(activate);
                db.SaveChanges();
                ViewBag.status = DateTime.Now.AddYears(1)+"تم تفعيل التطبيق بنجاح ينتهي في ";
                    return View();


                }
           
        }
            
        }


    }


