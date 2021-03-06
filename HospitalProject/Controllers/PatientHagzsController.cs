﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospitalProject.Models;
using System.Web.Routing;
using Microsoft.AspNet.Identity;

namespace HospitalProject.Controllers
{
    [Authorize]
    public class PatientHagzsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PatientHagzs
        public ActionResult Index()
        {
            var patientHagzs = db.PatientHagzs.Include(p => p.adwya).Include(p => p.marad).Include(p => p.ray).Include(p => p.tahlel).Include(p => p.tamen);
            return View(patientHagzs.ToList());
        }

        // GET: PatientHagzs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientHagz patientHagz = db.PatientHagzs.Find(id);
            if (patientHagz == null)
            {
                return HttpNotFound();
            }
            return View(patientHagz);
        }

        // GET: PatientHagzs/Create
        public ActionResult Create()
        {
            ViewBag.AdwyaId = new SelectList(db.Adwyas, "Id", "Name");
            ViewBag.MaradId = new SelectList(db.Marads, "Id", "Name");
             
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name");
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name");
            ViewBag.TamenId = new SelectList(db.Tamen, "Id", "Name");
            return View();
        }

        // POST: PatientHagzs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create( PatientHagz patientHagz,HesabatIn hesabat )
        {
            if (ModelState.IsValid)
            {

                patientHagz.KashfDate = DateTime.Now;

                patientHagz.AllMoney = ((patientHagz.MaradPriceM) - ((patientHagz.TamenpriceT * 100 ) / 100));
              
                db.PatientHagzs.Add(patientHagz);
                hesabat.PatientName = patientHagz.Name;
                hesabat.EntryMoney = ((patientHagz.MaradPriceM) - ((patientHagz.TamenpriceT * 100) / 100));
                hesabat.DateOfpay= DateTime.Now;
                hesabat.PayType = "كشف";
                db.HesabatIns.Add(hesabat);
                db.SaveChanges();
                
                return RedirectToAction("Details", new { id = patientHagz.Id });
            }

            ViewBag.AdwyaId = new SelectList(db.Adwyas, "Id", "Name", patientHagz.AdwyaId);
            ViewBag.MaradId = new SelectList(db.Marads, "Id", "Name", patientHagz.MaradId);
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name", patientHagz.RayId);
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name", patientHagz.TahlelId);
            ViewBag.TamenId = new SelectList(db.Tamen, "Id", "Name", patientHagz.TamenId);
            return View(patientHagz);
        }

        // GET: PatientHagzs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientHagz patientHagz = db.PatientHagzs.Find(id);
            if (patientHagz == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdwyaId = new SelectList(db.Adwyas, "Id", "Name", patientHagz.AdwyaId);
            ViewBag.MaradId = new SelectList(db.Marads, "Id", "Name", patientHagz.MaradId);
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name", patientHagz.RayId);
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name", patientHagz.TahlelId);
            ViewBag.TamenId = new SelectList(db.Tamen, "Id", "Name", patientHagz.TamenId);
            return View(patientHagz);
        }

        // POST: PatientHagzs/Edit/5
      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,Address,KashfDate,Number,MaradId,TamenId,IsBaid,Tashkhees,Rosheta,Esteshara,AdwyaId,RayId,TahlelId,EndTurn,CheckDate")] PatientHagz patientHagz)
        {
            var checkUser = User.IsInRole("Nurse");
           
            if (ModelState.IsValid)
            {
                db.Entry(patientHagz).State = EntityState.Modified;
                db.SaveChanges();
                if (checkUser)
                {
                    return RedirectToAction("Index");
                }
                return RedirectToAction("Search", "Home", new { searchName = patientHagz.Name });
            }
            ViewBag.AdwyaId = new SelectList(db.Adwyas, "Id", "Name", patientHagz.AdwyaId);     
            ViewBag.MaradId = new SelectList(db.Marads, "Id", "Name", patientHagz.MaradId);
            ViewBag.RayId = new SelectList(db.Rays, "Id", "Name", patientHagz.RayId);
            ViewBag.TahlelId = new SelectList(db.Tahlels, "Id", "Name", patientHagz.TahlelId);
            ViewBag.TamenId = new SelectList(db.Tamen, "Id", "Name", patientHagz.TamenId);

            return View(patientHagz);
        }

        // GET: PatientHagzs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PatientHagz patientHagz = db.PatientHagzs.Find(id);
            if (patientHagz == null)
            {
                return HttpNotFound();
            }
            return View(patientHagz);
        }

        // POST: PatientHagzs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PatientHagz patientHagz = db.PatientHagzs.Find(id);
            db.PatientHagzs.Remove(patientHagz);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetMaradPrice(int MaradId)
        {
            List<Marad> selectlist = db.Marads.Where(a => a.Id == MaradId).ToList();
            ViewBag.PriceM = new SelectList(selectlist, "Price", "Price");
            return PartialView("PriceM");
        }
        public ActionResult GetTamenPrice(int TamenId)
        {
            List<Tamen> selectlist = db.Tamen.Where(a => a.Id == TamenId).ToList();
            ViewBag.PriceT = new SelectList(selectlist, "Price", "Price");
            return PartialView("PriceT");
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
