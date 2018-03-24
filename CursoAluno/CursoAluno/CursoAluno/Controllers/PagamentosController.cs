using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CursoAluno.Models;

namespace CursoAluno.Controllers
{
    public class PagamentosController : Controller
    {
        private CursoAlunoContext db = new CursoAlunoContext();

        // GET: Pagamentos
        public ActionResult Index()
        {
            return View(db.Pagamentoes.ToList());
        }

        // GET: Pagamentos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagamento pagamento = db.Pagamentoes.Find(id);
            if (pagamento == null)
            {
                return HttpNotFound();
            }
            return View(pagamento);
        }

        // GET: Pagamentos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pagamentos/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CursoId,AlunoId,Valor")] Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                db.Pagamentoes.Add(pagamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pagamento);
        }

        // GET: Pagamentos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagamento pagamento = db.Pagamentoes.Find(id);
            if (pagamento == null)
            {
                return HttpNotFound();
            }
            return View(pagamento);
        }

        // POST: Pagamentos/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CursoId,AlunoId,Valor")] Pagamento pagamento)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pagamento).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pagamento);
        }

        // GET: Pagamentos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pagamento pagamento = db.Pagamentoes.Find(id);
            if (pagamento == null)
            {
                return HttpNotFound();
            }
            return View(pagamento);
        }

        // POST: Pagamentos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pagamento pagamento = db.Pagamentoes.Find(id);
            db.Pagamentoes.Remove(pagamento);
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
