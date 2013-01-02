using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DominionTracker.Models;

namespace DominionTracker.Controllers
{ 
    public class DominionSetController : Controller
    {
        private DominionTrackerContext db = new DominionTrackerContext();

        //
        // GET: /DominionSet/

        public ViewResult Index()
        {
            return View(db.DominionSetModels.ToList());
        }

        //
        // GET: /DominionSet/Details/5

        public ViewResult Details(int id)
        {
            DominionSetModel dominionsetmodel = db.DominionSetModels.Find(id);
            return View(dominionsetmodel);
        }

        //
        // GET: /DominionSet/Create

        [Authorize]
        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /DominionSet/Create

        [HttpPost]
        [Authorize]
        public ActionResult Create(DominionSetModel dominionsetmodel)
        {
            if (ModelState.IsValid)
            {
                db.DominionSetModels.Add(dominionsetmodel);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(dominionsetmodel);
        }
        
        //
        // GET: /DominionSet/Edit/5
        [Authorize]
        public ActionResult Edit(int id)
        {
            DominionSetModel dominionsetmodel = db.DominionSetModels.Find(id);
            return View(dominionsetmodel);
        }

        //
        // POST: /DominionSet/Edit/5

        [HttpPost]
        [Authorize]
        public ActionResult Edit(DominionSetModel dominionsetmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dominionsetmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dominionsetmodel);
        }

        //
        // GET: /DominionSet/Delete/5
        [Authorize]
        public ActionResult Delete(int id)
        {
            DominionSetModel dominionsetmodel = db.DominionSetModels.Find(id);
            return View(dominionsetmodel);
        }

        //
        // POST: /DominionSet/Delete/5

        [HttpPost, ActionName("Delete")]
        [Authorize]
        public ActionResult DeleteConfirmed(int id)
        {            
            DominionSetModel dominionsetmodel = db.DominionSetModels.Find(id);
            db.DominionSetModels.Remove(dominionsetmodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}