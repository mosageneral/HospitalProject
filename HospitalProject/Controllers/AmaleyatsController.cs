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
    public class AmaleyatsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Amaleyats
        public ActionResult Index()
        {
            return View(db.Amaleyats.ToList());
        }

        // GET: Amaleyats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amaleyat amaleyat = db.Amaleyats.Find(id);
            if (amaleyat == null)
            {
                return HttpNotFound();
            }
            return View(amaleyat);
        }

        // GET: Amaleyats/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Amaleyats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HesabatIn hesbat, Amaleyat amaleyat)
        {
            if (ModelState.IsValid)
            {
                amaleyat.Date = DateTime.Now;
                db.Amaleyats.Add(amaleyat);
                hesbat.EntryMoney = amaleyat.Price;
                hesbat.DateOfpay = DateTime.Now;
                hesbat.PatientName = amaleyat.PatientName;
                hesbat.PayType = "عملية";
                db.HesabatIns.Add(hesbat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(amaleyat);
        }

        // GET: Amaleyats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amaleyat amaleyat = db.Amaleyats.Find(id);
            if (amaleyat == null)
            {
                return HttpNotFound();
            }
            return View(amaleyat);
        }

        // POST: Amaleyats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,PatientName,Price,Date,IsDone")] Amaleyat amaleyat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(amaleyat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(amaleyat);
        }

        // GET: Amaleyats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Amaleyat amaleyat = db.Amaleyats.Find(id);
            if (amaleyat == null)
            {
                return HttpNotFound();
            }
            return View(amaleyat);
        }

        // POST: Amaleyats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Amaleyat amaleyat = db.Amaleyats.Find(id);
            db.Amaleyats.Remove(amaleyat);
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
