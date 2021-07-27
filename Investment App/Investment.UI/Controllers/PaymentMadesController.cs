using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Investment.UI.Models;

namespace Investment.UI.Controllers
{
    public class PaymentMadesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: PaymentMades
        public ActionResult Index()
        {
            return View(db.PaymentMades.ToList());
        }

        // GET: PaymentMades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentMade paymentMade = db.PaymentMades.Find(id);
            if (paymentMade == null)
            {
                return HttpNotFound();
            }
            return View(paymentMade);
        }

        // GET: PaymentMades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaymentMades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "payMadeId,status,dateCreate,dueDate,amtPaid,userName")] PaymentMade paymentMade)
        {
            if (ModelState.IsValid)
            {
                db.PaymentMades.Add(paymentMade);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(paymentMade);
        }

        // GET: PaymentMades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentMade paymentMade = db.PaymentMades.Find(id);
            if (paymentMade == null)
            {
                return HttpNotFound();
            }
            return View(paymentMade);
        }

        // POST: PaymentMades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "payMadeId,status,dateCreate,dueDate,amtPaid,userName")] PaymentMade paymentMade)
        {
            if (ModelState.IsValid)
            {
                db.Entry(paymentMade).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(paymentMade);
        }

        // GET: PaymentMades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PaymentMade paymentMade = db.PaymentMades.Find(id);
            if (paymentMade == null)
            {
                return HttpNotFound();
            }
            return View(paymentMade);
        }

        // POST: PaymentMades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PaymentMade paymentMade = db.PaymentMades.Find(id);
            db.PaymentMades.Remove(paymentMade);
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
