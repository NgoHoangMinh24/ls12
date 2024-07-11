using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Views
{
    public class nhm_SACHController : Controller
    {
        private ngohoangminh_2210900044Entities db = new ngohoangminh_2210900044Entities();

        // GET: nhm_SACH
        public ActionResult NhmIndex()
        {
            var nhm_SACH = db.nhm_SACH.Include(n => n.nhm_TACGIA);
            return View(nhm_SACH.ToList());
        }

        // GET: nhm_SACH/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhm_SACH nhm_SACH = db.nhm_SACH.Find(id);
            if (nhm_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nhm_SACH);
        }

        // GET: nhm_SACH/Create
        public ActionResult Create()
        {
            ViewBag.nhm_MaTG = new SelectList(db.nhm_TACGIA, "nhm_MaTG", "nhm_TenTacGia");
            return View();
        }

        // POST: nhm_SACH/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "nhm_MaSach,nhm_TenSach,nhm_SoTrang,nhm_NamXB,nhm_MaTG,nhm_TrangThai")] nhm_SACH nhm_SACH)
        {
            if (ModelState.IsValid)
            {
                db.nhm_SACH.Add(nhm_SACH);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.nhm_MaTG = new SelectList(db.nhm_TACGIA, "nhm_MaTG", "nhm_TenTacGia", nhm_SACH.nhm_MaTG);
            return View(nhm_SACH);
        }

        // GET: nhm_SACH/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhm_SACH nhm_SACH = db.nhm_SACH.Find(id);
            if (nhm_SACH == null)
            {
                return HttpNotFound();
            }
            ViewBag.nhm_MaTG = new SelectList(db.nhm_TACGIA, "nhm_MaTG", "nhm_TenTacGia", nhm_SACH.nhm_MaTG);
            return View(nhm_SACH);
        }

        // POST: nhm_SACH/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "nhm_MaSach,nhm_TenSach,nhm_SoTrang,nhm_NamXB,nhm_MaTG,nhm_TrangThai")] nhm_SACH nhm_SACH)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nhm_SACH).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.nhm_MaTG = new SelectList(db.nhm_TACGIA, "nhm_MaTG", "nhm_TenTacGia", nhm_SACH.nhm_MaTG);
            return View(nhm_SACH);
        }

        // GET: nhm_SACH/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            nhm_SACH nhm_SACH = db.nhm_SACH.Find(id);
            if (nhm_SACH == null)
            {
                return HttpNotFound();
            }
            return View(nhm_SACH);
        }

        // POST: nhm_SACH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            nhm_SACH nhm_SACH = db.nhm_SACH.Find(id);
            db.nhm_SACH.Remove(nhm_SACH);
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
