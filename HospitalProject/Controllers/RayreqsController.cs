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
    public class RayreqsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rayreqs
        public ActionResult Index()
        {
            var rayreqs = db.Rayreqs.Include(r => r.ray);
            return View(rayreqs.ToList());
        }

        // GET: Rayreqs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rayreq rayreq = db.Rayreqs.Find(id);
            if (rayreq == null)
            {
                return HttpNotFound();
            }
            return View(rayreq);
        }

        // GET: Rayreqs/Create
        public ActionResult Create()
        {
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name");
            return View();
        }

        // POST: Rayreqs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HesabatIn hesabat, Rayreq rayreq)
        {
            if (ModelState.IsValid)
            {
                rayreq.DateOfRay = DateTime.Now;
                db.Rayreqs.Add(rayreq);
                hesabat.DateOfpay = rayreq.DateOfRay;
                hesabat.EntryMoney = rayreq.Price;
                hesabat.PatientName = rayreq.PateintName;
                hesabat.PayType = "أشعه";
                db.HesabatIns.Add(hesabat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name", rayreq.RayId);
            return View(rayreq);
        }

        // GET: Rayreqs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rayreq rayreq = db.Rayreqs.Find(id);
            if (rayreq == null)
            {
                return HttpNotFound();
            }
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name", rayreq.RayId);
            return View(rayreq);
        }

        // POST: Rayreqs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,RayId,PateintName,DateOfRay,Price")] Rayreq rayreq)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rayreq).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name", rayreq.RayId);
            return View(rayreq);
        }

        // GET: Rayreqs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rayreq rayreq = db.Rayreqs.Find(id);
            if (rayreq == null)
            {
                return HttpNotFound();
            }
            return View(rayreq);
        }

        // POST: Rayreqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rayreq rayreq = db.Rayreqs.Find(id);
            db.Rayreqs.Remove(rayreq);
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
