using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Eco1;

namespace Eco1.Controllers
{
    public class EntidadesController : Controller
    {
        private EconomatoEntities db = new EconomatoEntities();

        // GET: Entidades
        public ActionResult Index()
        {
            return View(db.Entidades.ToList());
        }

        // GET: Entidades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidades entidades = db.Entidades.Find(id);
            if (entidades == null)
            {
                return HttpNotFound();
            }
            return View(entidades);
        }

        // GET: Entidades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Entidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEntidade,Designacao")] Entidades entidades)
        {
            if (ModelState.IsValid)
            {
                db.Entidades.Add(entidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entidades);
        }

        // GET: Entidades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidades entidades = db.Entidades.Find(id);
            if (entidades == null)
            {
                return HttpNotFound();
            }
            return View(entidades);
        }

        // POST: Entidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEntidade,Designacao")] Entidades entidades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entidades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entidades);
        }

        // GET: Entidades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Entidades entidades = db.Entidades.Find(id);
            if (entidades == null)
            {
                return HttpNotFound();
            }
            return View(entidades);
        }

        // POST: Entidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Entidades entidades = db.Entidades.Find(id);
            db.Entidades.Remove(entidades);
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
