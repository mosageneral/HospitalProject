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
    public class MaradsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Marads
        public ActionResult Index()
        {
            return View(db.Marads.ToList());
        }

        // GET: Marads/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marad marad = db.Marads.Find(id);
            if (marad == null)
            {
                return HttpNotFound();
            }
            return View(marad);
        }

        // GET: Marads/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Marads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price")] Marad marad)
        {
            if (ModelState.IsValid)
            {
                db.Marads.Add(marad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(marad);
        }

        // GET: Marads/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marad marad = db.Marads.Find(id);
            if (marad == null)
            {
                return HttpNotFound();
            }
            return View(marad);
        }

        // POST: Marads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price")] Marad marad)
        {
            if (ModelState.IsValid)
            {
                db.Entry(marad).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(marad);
        }

        // GET: Marads/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Marad marad = db.Marads.Find(id);
            if (marad == null)
            {
                return HttpNotFound();
            }
            return View(marad);
        }

        // POST: Marads/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Marad marad = db.Marads.Find(id);
            db.Marads.Remove(marad);
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
