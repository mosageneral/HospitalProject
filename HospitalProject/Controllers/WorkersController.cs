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
    public class WorkersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Workers
        public ActionResult Index()
        {
            return View(db.Workers.ToList());
        }

        // GET: Workers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workers workers = db.Workers.Find(id);
            if (workers == null)
            {
                return HttpNotFound();
            }
            return View(workers);
        }

        // GET: Workers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Workers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Job,Age,Salary,Address,Phone,Describ,CardId")] Workers workers)
        {
            if (ModelState.IsValid)
            {
                db.Workers.Add(workers);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(workers);
        }

        // GET: Workers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workers workers = db.Workers.Find(id);
            if (workers == null)
            {
                return HttpNotFound();
            }
            return View(workers);
        }

        // POST: Workers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Job,Age,Salary,Address,Phone,Describ,CardId")] Workers workers)
        {
            if (ModelState.IsValid)
            {
                db.Entry(workers).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(workers);
        }

        // GET: Workers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Workers workers = db.Workers.Find(id);
            if (workers == null)
            {
                return HttpNotFound();
            }
            return View(workers);
        }

        // POST: Workers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Workers workers = db.Workers.Find(id);
            db.Workers.Remove(workers);
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
