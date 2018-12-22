using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fidelitas.Proyecto.ArticulosPerdidos.Model;

namespace Fidelitas.Proyecto.ArticulosPerdidos.Controllers
{
   // [Authorize(Roles = "Admin, Invitado")]
    public class PERSONA_REPORTANDO_EXTRAVIOController : Controller
    {
        private ProyectoProgra5Entities1 db = new ProyectoProgra5Entities1();

        // GET: PERSONA_REPORTANDO_EXTRAVIO
        public ActionResult Index()
        {
            var pERSONA_REPORTANDO_EXTRAVIO = db.PERSONA_REPORTANDO_EXTRAVIO.Include(p => p.CATEGORIA_ARTICULO).Include(p => p.PERSONA);
            return View(pERSONA_REPORTANDO_EXTRAVIO.ToList());
        }

        // GET: PERSONA_REPORTANDO_EXTRAVIO/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PERSONA_REPORTANDO_EXTRAVIO pERSONA_REPORTANDO_EXTRAVIO = db.PERSONA_REPORTANDO_EXTRAVIO.Find(id);
            if (pERSONA_REPORTANDO_EXTRAVIO == null)
            {
                return HttpNotFound();
            }
            return View(pERSONA_REPORTANDO_EXTRAVIO);
        }

        // GET: PERSONA_REPORTANDO_EXTRAVIO/Create
        public ActionResult Create()
        {
            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIA_ARTICULO, "ID", "NOMBRE_CATEGORIA");
            ViewBag.ID_PERSONA = new SelectList(db.PERSONA, "ID", "NOMBRE_COMPLETO");
            return View();
        }

        // POST: PERSONA_REPORTANDO_EXTRAVIO/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ID_PERSONA,ID_CATEGORIA,FECHA_REPORTE")] PERSONA_REPORTANDO_EXTRAVIO pERSONA_REPORTANDO_EXTRAVIO)
        {
            if (ModelState.IsValid)
            {
                db.PERSONA_REPORTANDO_EXTRAVIO.Add(pERSONA_REPORTANDO_EXTRAVIO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIA_ARTICULO, "ID", "NOMBRE_CATEGORIA", pERSONA_REPORTANDO_EXTRAVIO.ID_CATEGORIA);
            ViewBag.ID_PERSONA = new SelectList(db.PERSONA, "ID", "NOMBRE_COMPLETO", pERSONA_REPORTANDO_EXTRAVIO.ID_PERSONA);
            return View(pERSONA_REPORTANDO_EXTRAVIO);
        }

        // GET: PERSONA_REPORTANDO_EXTRAVIO/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PERSONA_REPORTANDO_EXTRAVIO pERSONA_REPORTANDO_EXTRAVIO = db.PERSONA_REPORTANDO_EXTRAVIO.Find(id);
            if (pERSONA_REPORTANDO_EXTRAVIO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIA_ARTICULO, "ID", "NOMBRE_CATEGORIA", pERSONA_REPORTANDO_EXTRAVIO.ID_CATEGORIA);
            ViewBag.ID_PERSONA = new SelectList(db.PERSONA, "ID", "NOMBRE_COMPLETO", pERSONA_REPORTANDO_EXTRAVIO.ID_PERSONA);
            return View(pERSONA_REPORTANDO_EXTRAVIO);
        }

        // POST: PERSONA_REPORTANDO_EXTRAVIO/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ID_PERSONA,ID_CATEGORIA,FECHA_REPORTE")] PERSONA_REPORTANDO_EXTRAVIO pERSONA_REPORTANDO_EXTRAVIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pERSONA_REPORTANDO_EXTRAVIO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CATEGORIA = new SelectList(db.CATEGORIA_ARTICULO, "ID", "NOMBRE_CATEGORIA", pERSONA_REPORTANDO_EXTRAVIO.ID_CATEGORIA);
            ViewBag.ID_PERSONA = new SelectList(db.PERSONA, "ID", "NOMBRE_COMPLETO", pERSONA_REPORTANDO_EXTRAVIO.ID_PERSONA);
            return View(pERSONA_REPORTANDO_EXTRAVIO);
        }

        // GET: PERSONA_REPORTANDO_EXTRAVIO/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PERSONA_REPORTANDO_EXTRAVIO pERSONA_REPORTANDO_EXTRAVIO = db.PERSONA_REPORTANDO_EXTRAVIO.Find(id);
            if (pERSONA_REPORTANDO_EXTRAVIO == null)
            {
                return HttpNotFound();
            }
            return View(pERSONA_REPORTANDO_EXTRAVIO);
        }

        // POST: PERSONA_REPORTANDO_EXTRAVIO/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PERSONA_REPORTANDO_EXTRAVIO pERSONA_REPORTANDO_EXTRAVIO = db.PERSONA_REPORTANDO_EXTRAVIO.Find(id);
            db.PERSONA_REPORTANDO_EXTRAVIO.Remove(pERSONA_REPORTANDO_EXTRAVIO);
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
