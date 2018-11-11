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
    public class tahlelreqsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: tahlelreqs
        public ActionResult Index()
        {
            var tahlelreqs = db.tahlelreqs.Include(t => t.tahlel);
            return View(tahlelreqs.ToList());
        }

        // GET: tahlelreqs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tahlelreq tahlelreq = db.tahlelreqs.Find(id);
            if (tahlelreq == null)
            {
                return HttpNotFound();
            }
            return View(tahlelreq);
        }

        // GET: tahlelreqs/Create
        public ActionResult Create()
        {
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name");
            return View();
        }

        // POST: tahlelreqs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HesabatIn hesabat, tahlelreq tahlelreq)
        {
            if (ModelState.IsValid)
            {
                tahlelreq.DateOfTahlel = DateTime.Now;

                db.tahlelreqs.Add(tahlelreq);
                hesabat.DateOfpay = tahlelreq.DateOfTahlel;
                hesabat.EntryMoney = tahlelreq.Price;
                hesabat.PatientName = tahlelreq.PateintName;
                hesabat.PayType = "تحليل";
                db.HesabatIns.Add(hesabat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name", tahlelreq.TahlelId);
            return View(tahlelreq);
        }

        // GET: tahlelreqs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tahlelreq tahlelreq = db.tahlelreqs.Find(id);
            if (tahlelreq == null)
            {
                return HttpNotFound();
            }
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name", tahlelreq.TahlelId);
            return View(tahlelreq);
        }

        // POST: tahlelreqs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,TahlelId,PateintName,DateOfTahlel,Price")] tahlelreq tahlelreq)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tahlelreq).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name", tahlelreq.TahlelId);
            return View(tahlelreq);
        }

        // GET: tahlelreqs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tahlelreq tahlelreq = db.tahlelreqs.Find(id);
            if (tahlelreq == null)
            {
                return HttpNotFound();
            }
            return View(tahlelreq);
        }

        // POST: tahlelreqs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tahlelreq tahlelreq = db.tahlelreqs.Find(id);
            db.tahlelreqs.Remove(tahlelreq);
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
