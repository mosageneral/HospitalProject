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
    public class TahlelsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Tahlels
        public ActionResult Index()
        {
            return View(db.Tahlels.ToList());
        }

        // GET: Tahlels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tahlel tahlel = db.Tahlels.Find(id);
            if (tahlel == null)
            {
                return HttpNotFound();
            }
            return View(tahlel);
        }

        // GET: Tahlels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tahlels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Price")] Tahlel tahlel)
        {
            if (ModelState.IsValid)
            {
                db.Tahlels.Add(tahlel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tahlel);
        }

        // GET: Tahlels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tahlel tahlel = db.Tahlels.Find(id);
            if (tahlel == null)
            {
                return HttpNotFound();
            }
            return View(tahlel);
        }

        // POST: Tahlels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Price")] Tahlel tahlel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tahlel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tahlel);
        }

        // GET: Tahlels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tahlel tahlel = db.Tahlels.Find(id);
            if (tahlel == null)
            {
                return HttpNotFound();
            }
            return View(tahlel);
        }

        // POST: Tahlels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tahlel tahlel = db.Tahlels.Find(id);
            db.Tahlels.Remove(tahlel);
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
