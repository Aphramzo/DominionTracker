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
    public class CardController : Controller
    {
        private DominionTrackerContext db = new DominionTrackerContext();

        //
        // GET: /Card/

        public ViewResult Index()
        {
            return View(db.CardModels.ToList());
        }

        //
        // GET: /Card/Details/5

        public ViewResult Details(int id)
        {
            CardModel cardmodel = db.CardModels.Find(id);
            return View(cardmodel);
        }

        //
        // GET: /Card/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Card/Create

        [HttpPost]
        public ActionResult Create(CardModel cardmodel)
        {
            if (ModelState.IsValid)
            {
                db.CardModels.Add(cardmodel);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(cardmodel);
        }
        
        //
        // GET: /Card/Edit/5
 
        public ActionResult Edit(int id)
        {
            CardModel cardmodel = db.CardModels.Find(id);
            return View(cardmodel);
        }

        //
        // POST: /Card/Edit/5

        [HttpPost]
        public ActionResult Edit(CardModel cardmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cardmodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cardmodel);
        }

        //
        // GET: /Card/Delete/5
 
        public ActionResult Delete(int id)
        {
            CardModel cardmodel = db.CardModels.Find(id);
            return View(cardmodel);
        }

        //
        // POST: /Card/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            CardModel cardmodel = db.CardModels.Find(id);
            db.CardModels.Remove(cardmodel);
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