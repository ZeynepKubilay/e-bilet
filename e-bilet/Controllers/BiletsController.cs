using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using e_bilet.Models;
using e_bilet.Models.Managers;

namespace e_bilet.Controllers
{
    public class BiletsController : Controller
    {
        private EFEbiletDBEntities2 db = new EFEbiletDBEntities2();

        // GET: Bilets
        public ActionResult Index()
        {
            List<tblBilet> bilets = db.tblBilet.Include(b => b.tblEtkinlik).ToList();
            return View(bilets);
        }

        // GET: Bilets/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBilet bilet = await db.tblBilet.FindAsync(id);
            if (bilet == null)
            {
                return HttpNotFound();
            }
            return View(bilet);
        }

        // GET: Bilets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bilets/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(tblBilet bilet)
        {

                db.tblBilet.Add(bilet);
                int sonuc = db.SaveChanges();
            if (sonuc > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(bilet);
            }
        }

        // GET: Bilets/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBilet bilet = await db.tblBilet.FindAsync(id);
            if (bilet == null)
            {
                return HttpNotFound();
            }
            return View(bilet);
        }

        // POST: Bilets/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BiletID,EtkinlikID,Ucret")] tblBilet bilet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bilet).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(bilet);
        }

        // GET: Bilets/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tblBilet bilet = await db.tblBilet.FindAsync(id);
            if (bilet == null)
            {
                return HttpNotFound();
            }
            return View(bilet);
        }

        // POST: Bilets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            tblBilet bilet = await db.tblBilet.FindAsync(id);
            db.tblBilet.Remove(bilet);
            await db.SaveChangesAsync();
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
