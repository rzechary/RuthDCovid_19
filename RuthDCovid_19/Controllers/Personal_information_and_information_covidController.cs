using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using RuthDCovid_19.Models;

namespace RuthDCovid_19.Controllers
{
    public class Personal_information_and_information_covidController : Controller
    {
        private RuthDausDataBaseCovid_19Entities db = new RuthDausDataBaseCovid_19Entities();

        // GET: Personal_information_and_information_covid
        public ActionResult Index()
        {
            return View(db.Personal_information_and_information_covid.ToList());
        }

        // GET: Personal_information_and_information_covid/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_information_and_information_covid personal_information_and_information_covid = db.Personal_information_and_information_covid.Find(id);
            if (personal_information_and_information_covid == null)
            {
                return HttpNotFound();
            }
            return View(personal_information_and_information_covid);
        }

        // GET: Personal_information_and_information_covid/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personal_information_and_information_covid/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "name1,last_name,id,aaddress,date_of_birth,pone,mobile_phone,date_vac1,manufacturer_vac1,date_vac2,manufacturer_vac2,date_vac3,manufacturer_vac3,date_vac4,manufacturer_vac4,date_positive_result,date_recovery")] Personal_information_and_information_covid personal_information_and_information_covid)
        {
            if (ModelState.IsValid)
            {
                if (personal_information_and_information_covid.date_positive_result < personal_information_and_information_covid.date_recovery)
                    db.Personal_information_and_information_covid.Add(personal_information_and_information_covid);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(personal_information_and_information_covid);
        }

        // GET: Personal_information_and_information_covid/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_information_and_information_covid personal_information_and_information_covid = db.Personal_information_and_information_covid.Find(id);
            if (personal_information_and_information_covid == null)
            {
                return HttpNotFound();
            }
            return View(personal_information_and_information_covid);
        }

        // POST: Personal_information_and_information_covid/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "name1,last_name,id,aaddress,date_of_birth,pone,mobile_phone,date_vac1,manufacturer_vac1,date_vac2,manufacturer_vac2,date_vac3,manufacturer_vac3,date_vac4,manufacturer_vac4,date_positive_result,date_recovery")] Personal_information_and_information_covid personal_information_and_information_covid)
        {
            if (ModelState.IsValid)
            {
                db.Entry(personal_information_and_information_covid).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(personal_information_and_information_covid);
        }

        // GET: Personal_information_and_information_covid/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Personal_information_and_information_covid personal_information_and_information_covid = db.Personal_information_and_information_covid.Find(id);
            if (personal_information_and_information_covid == null)
            {
                return HttpNotFound();
            }
            return View(personal_information_and_information_covid);
        }

        // POST: Personal_information_and_information_covid/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Personal_information_and_information_covid personal_information_and_information_covid = db.Personal_information_and_information_covid.Find(id);
            db.Personal_information_and_information_covid.Remove(personal_information_and_information_covid);
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
