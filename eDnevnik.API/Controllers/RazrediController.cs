using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using eDnevnik.API.Models;

namespace eDnevnik.API.Controllers
{
    public class RazrediController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/Razredi
        public List<RazredVM> GetRazred()
        {
            return db.Razred.Select(x => new RazredVM
            {
                RazredId = x.RazredId,
                Naziv = x.Naziv,
                AkademskaGodina = x.AkademskaGodina.Naziv,
                Odjeljenje = x.Odjeljenje,
                RazredOdjeljenje = x.Naziv + " - " + x.Odjeljenje,
                AkademskaGodinaId = x.AkademskaGodinaId
            }).ToList();
        }

        // GET: api/Razredi/5
        [ResponseType(typeof(RazredVM))]
        public IHttpActionResult GetRazred(int id)
        {
            RazredVM razred = db.Razred.Where(x=>x.RazredId == id).Select(x => new RazredVM
            {
                RazredId = x.RazredId,
                Naziv = x.Naziv,
                AkademskaGodina = x.AkademskaGodina.Naziv,
                Odjeljenje = x.Odjeljenje,
                RazredOdjeljenje = x.Naziv + " - " + x.Odjeljenje,
                AkademskaGodinaId = x.AkademskaGodinaId
            }).Single();
            if (razred == null)
            {
                return NotFound();
            }

            return Ok(razred);
        }

        // PUT: api/Razredi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRazred(int id, Razred razred)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != razred.RazredId)
            {
                return BadRequest();
            }

            db.Entry(razred).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RazredExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Razredi
        [ResponseType(typeof(Razred))]
        public IHttpActionResult PostRazred(Razred razred)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Razred.Add(razred);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = razred.RazredId }, razred);
        }

        // DELETE: api/Razredi/5
        [ResponseType(typeof(Razred))]
        public IHttpActionResult DeleteRazred(int id)
        {
            Razred razred = db.Razred.Find(id);
            if (razred == null)
            {
                return NotFound();
            }

            db.Razred.Remove(razred);
            db.SaveChanges();

            return Ok(razred);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RazredExists(int id)
        {
            return db.Razred.Count(e => e.RazredId == id) > 0;
        }
    }
}