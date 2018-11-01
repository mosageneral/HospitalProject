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
    public class RaysController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rays
        public ActionResult Index()
        {
            return View(db.Rays.ToList());
        }

        // GET: Rays/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ray ray = db.Rays.Find(id);
            if (ray == null)
            {
                return HttpNotFound();
            }
            return View(ray);
        }

        // GET: Rays/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rays/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name")] Ray ray)
        {
            if (ModelState.IsValid)
            {
                db.Rays.Add(ray);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ray);
        }

        // GET: Rays/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ray ray = db.Rays.Find(id);
            if (ray == null)
            {
                return HttpNotFound();
            }
            return View(ray);
        }

        // POST: Rays/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name")] Ray ray)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ray).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ray);
        }

        // GET: Rays/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ray ray = db.Rays.Find(id);
            if (ray == null)
            {
                return HttpNotFound();
            }
            return View(ray);
        }

        // POST: Rays/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ray ray = db.Rays.Find(id);
            db.Rays.Remove(ray);
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
