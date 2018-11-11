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
    [Authorize]
    public class HesabatInsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HesabatIns
        public ActionResult Index()
            
        {
            var sum = db.HesabatIns.Sum(a => a.EntryMoney);
            ViewBag.sum = sum;
            return View(db.HesabatIns.ToList());
        }

        // GET: HesabatIns/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HesabatIn hesabatIn = db.HesabatIns.Find(id);
            if (hesabatIn == null)
            {
                return HttpNotFound();
            }
            return View(hesabatIn);
        }

        // GET: HesabatIns/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HesabatIns/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PatientName,EntryMoney")] HesabatIn hesabatIn)
        {
            if (ModelState.IsValid)
            {
                db.HesabatIns.Add(hesabatIn);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hesabatIn);
        }

        // GET: HesabatIns/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HesabatIn hesabatIn = db.HesabatIns.Find(id);
            if (hesabatIn == null)
            {
                return HttpNotFound();
            }
            return View(hesabatIn);
        }

        // POST: HesabatIns/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PatientName,EntryMoney")] HesabatIn hesabatIn)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hesabatIn).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hesabatIn);
        }

        // GET: HesabatIns/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HesabatIn hesabatIn = db.HesabatIns.Find(id);
            if (hesabatIn == null)
            {
                return HttpNotFound();
            }
            return View(hesabatIn);
        }

        // POST: HesabatIns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HesabatIn hesabatIn = db.HesabatIns.Find(id);
            db.HesabatIns.Remove(hesabatIn);
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
