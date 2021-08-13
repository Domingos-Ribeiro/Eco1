using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Eco1.Controllers
{
    public class AController : Controller
    {
        EconomatoEntities db = new EconomatoEntities();
        // GET: A


        //Listagem
        public ActionResult Index()
        {
            return View(db.Entidades.ToList());
        }

        //Create
        [HttpGet]
        public ActionResult Create()
        {
            return View(new Entidades());
        }

        [HttpPost]
        public ActionResult Create(Entidades entidades)
        {
            if (ModelState.IsValid)
            {
                db.Entidades.Add(entidades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(entidades);
            }
        }

        
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
    }
}