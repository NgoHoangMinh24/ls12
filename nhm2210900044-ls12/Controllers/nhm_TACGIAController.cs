using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class nhm_TACGIAController : Controller
    {
        private ngohoangminh_2210900044Entities db = new ngohoangminh_2210900044Entities();

        // GET: nhm_TACGIA
        public ActionResult NhmIndex()
        {
            return View(db.nhm_TACGIA.ToList());
        }

        // GET: nhm_TACGIA/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhm_TACGIA nhm_TACGIA = db.nhm_TACGIA.Find(id);
            if (nhm_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nhm_TACGIA);
        }

        // GET: nhm_TACGIA/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: nhm_TACGIA/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nhm_MaTG,nhm_TenTacGia")] nhm_TACGIA nhm_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.nhm_TACGIA.Add(nhm_TACGIA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nhm_TACGIA);
        }

        // GET: nhm_TACGIA/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhm_TACGIA nhm_TACGIA = db.nhm_TACGIA.Find(id);
            if (nhm_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nhm_TACGIA);
        }

        // POST: nhm_TACGIA/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nhm_MaTG,nhm_TenTacGia")] nhm_TACGIA nhm_TACGIA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhm_TACGIA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nhm_TACGIA);
        }

        // GET: nhm_TACGIA/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhm_TACGIA nhm_TACGIA = db.nhm_TACGIA.Find(id);
            if (nhm_TACGIA == null)
            {
                return HttpNotFound();
            }
            return View(nhm_TACGIA);
        }

        // POST: nhm_TACGIA/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nhm_TACGIA nhm_TACGIA = db.nhm_TACGIA.Find(id);
            db.nhm_TACGIA.Remove(nhm_TACGIA);
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
