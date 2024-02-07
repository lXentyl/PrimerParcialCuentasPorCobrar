using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CuentasPorCobrar.Db;

namespace CuentasPorCobrar.Controllers
{
    public class TransaccionesController : Controller
    {
        private INF244Entities1 db = new INF244Entities1();

        // GET: Transacciones
        public ActionResult Index()
        {
            var transaccions = db.Transaccions.Include(t => t.Cliente).Include(t => t.TipoDocumento).Include(t => t.TipoTransaccion);
            return View(transaccions.ToList());
        }

        // GET: Transacciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaccion transaccion = db.Transaccions.Find(id);
            if (transaccion == null)
            {
                return HttpNotFound();
            }
            return View(transaccion);
        }

        // GET: Transacciones/Create
        public ActionResult Create()
        {
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre");
            ViewBag.IdTipoDocumento = new SelectList(db.TipoDocumentoes, "IdTipoDocumento", "Descripcion");
            ViewBag.IdTipoTransaccion = new SelectList(db.TipoTransaccions, "IdTipoTransaccion", "Descripcion");
            return View();
        }

        // POST: Transacciones/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdTransaccion,IdTipoTransaccion,IdTipoDocumento,IdCliente,NumeroDocumento, fecha,Monto")] Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                db.Transaccions.Add(transaccion);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre", transaccion.IdCliente);
            ViewBag.IdTipoDocumento = new SelectList(db.TipoDocumentoes, "IdTipoDocumento", "Descripcion", transaccion.IdTipoDocumento);
            ViewBag.IdTipoTransaccion = new SelectList(db.TipoTransaccions, "IdTipoTransaccion", "Descripcion", transaccion.IdTipoTransaccion);
            return View(transaccion);
        }

        // GET: Transacciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaccion transaccion = db.Transaccions.Find(id);
            if (transaccion == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre", transaccion.IdCliente);
            ViewBag.IdTipoDocumento = new SelectList(db.TipoDocumentoes, "IdTipoDocumento", "Descripcion", transaccion.IdTipoDocumento);
            ViewBag.IdTipoTransaccion = new SelectList(db.TipoTransaccions, "IdTipoTransaccion", "Descripcion", transaccion.IdTipoTransaccion);
            return View(transaccion);
        }

        // POST: Transacciones/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdTransaccion,IdTipoTransaccion,IdTipoDocumento,IdCliente,NumeroDocumento,Fecha,Monto")] Transaccion transaccion)
        {
            if (ModelState.IsValid)
            {
                db.Entry(transaccion).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdCliente = new SelectList(db.Clientes, "IdCliente", "Nombre", transaccion.IdCliente);
            ViewBag.IdTipoDocumento = new SelectList(db.TipoDocumentoes, "IdTipoDocumento", "Descripcion", transaccion.IdTipoDocumento);
            ViewBag.IdTipoTransaccion = new SelectList(db.TipoTransaccions, "IdTipoTransaccion", "Descripcion", transaccion.IdTipoTransaccion);
            return View(transaccion);
        }

        // GET: Transacciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Transaccion transaccion = db.Transaccions.Find(id);
            if (transaccion == null)
            {
                return HttpNotFound();
            }
            return View(transaccion);
        }

        // POST: Transacciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Transaccion transaccion = db.Transaccions.Find(id);
            db.Transaccions.Remove(transaccion);
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
