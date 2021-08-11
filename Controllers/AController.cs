using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}