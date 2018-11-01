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
    public class AdwyasController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Adwyas
        public ActionResult Index()
        {
            return View(db.Adwyas.ToList());
        }

        // GET: Adwyas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adwya adwya = db.Adwyas.Find(id);
            if (adwya == null)
            {
                return HttpNotFound();
            }
            return View(adwya);
        }

        // GET: Adwyas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Adwyas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Content0,Content1,Content2,Content3,Content4,Content5,Content6,Content7")] Adwya adwya)
        {
            if (ModelState.IsValid)
            {
                db.Adwyas.Add(adwya);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(adwya);
        }

        // GET: Adwyas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adwya adwya = db.Adwyas.Find(id);
            if (adwya == null)
            {
                return HttpNotFound();
            }
            return View(adwya);
        }

        // POST: Adwyas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Content0,Content1,Content2,Content3,Content4,Content5,Content6,Content7")] Adwya adwya)
        {
            if (ModelState.IsValid)
            {
                db.Entry(adwya).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(adwya);
        }

        // GET: Adwyas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Adwya adwya = db.Adwyas.Find(id);
            if (adwya == null)
            {
                return HttpNotFound();
            }
            return View(adwya);
        }

        // POST: Adwyas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Adwya adwya = db.Adwyas.Find(id);
            db.Adwyas.Remove(adwya);
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
