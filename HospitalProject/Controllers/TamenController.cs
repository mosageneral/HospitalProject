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
    public class TamenController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tamen
        public ActionResult Index()
        {
            return View(db.Tamen.ToList());
        }

        // GET: Tamen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tamen tamen = db.Tamen.Find(id);
            if (tamen == null)
            {
                return HttpNotFound();
            }
            return View(tamen);
        }

        // GET: Tamen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tamen/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Address,PhoneNumber,Agent,Email,WebSite,Price")] Tamen tamen)
        {
            if (ModelState.IsValid)
            {
                db.Tamen.Add(tamen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tamen);
        }

        // GET: Tamen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tamen tamen = db.Tamen.Find(id);
            if (tamen == null)
            {
                return HttpNotFound();
            }
            return View(tamen);
        }

        // POST: Tamen/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Address,PhoneNumber,Agent,Email,WebSite,Price")] Tamen tamen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tamen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tamen);
        }

        // GET: Tamen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tamen tamen = db.Tamen.Find(id);
            if (tamen == null)
            {
                return HttpNotFound();
            }
            return View(tamen);
        }

        // POST: Tamen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tamen tamen = db.Tamen.Find(id);
            db.Tamen.Remove(tamen);
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
