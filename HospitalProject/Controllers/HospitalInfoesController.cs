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
    public class HospitalInfoesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HospitalInfoes
        public ActionResult Index()
        {
            return View(db.HospitalInfoes.ToList());
        }
      

        // GET: HospitalInfoes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalInfo hospitalInfo = db.HospitalInfoes.Find(id);
            if (hospitalInfo == null)
            {
                return HttpNotFound();
            }
            return View(hospitalInfo);
        }

        // GET: HospitalInfoes/Create
        public ActionResult Create()
        {
            var check = db.HospitalInfoes.Where(a => a.Id > 0);
            var check2 = check.Count();
            if (check2>0)
            {
                return HttpNotFound();
            }
            return View();
        }

        // POST: HospitalInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,ContactPhone,ContactMobile,Contactmobile2,DoctorName")] HospitalInfo hospitalInfo)
        {
            if (ModelState.IsValid)
            {
                db.HospitalInfoes.Add(hospitalInfo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hospitalInfo);
        }

        // GET: HospitalInfoes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalInfo hospitalInfo = db.HospitalInfoes.Find(id);
            if (hospitalInfo == null)
            {
                return HttpNotFound();
            }
            return View(hospitalInfo);
        }

        // POST: HospitalInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,ContactPhone,ContactMobile,Contactmobile2,DoctorName")] HospitalInfo hospitalInfo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hospitalInfo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hospitalInfo);
        }

        // GET: HospitalInfoes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HospitalInfo hospitalInfo = db.HospitalInfoes.Find(id);
            if (hospitalInfo == null)
            {
                return HttpNotFound();
            }
            return View(hospitalInfo);
        }

        // POST: HospitalInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HospitalInfo hospitalInfo = db.HospitalInfoes.Find(id);
            db.HospitalInfoes.Remove(hospitalInfo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
