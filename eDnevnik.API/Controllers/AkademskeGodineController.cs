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
    public class AkademskeGodineController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/AkademskeGodine
        public List<AkademskaGodinaVM> GetAkademskeGodine()
        {
            return db.AkademskaGodina.Select(x=> new AkademskaGodinaVM
            {
                AkademskaGodinaId = x.AkademskaGodinaId,
                Naziv = x.Naziv
            }).ToList();
        }

        // GET: api/AkademskeGodine/5
        [ResponseType(typeof(AkademskaGodina))]
        public IHttpActionResult GetAkademskaGodina(int id)
        {
            AkademskaGodina akademskaGodina = db.AkademskaGodina.Find(id);
            if (akademskaGodina == null)
            {
                return NotFound();
            }

            return Ok(akademskaGodina);
        }

        // PUT: api/AkademskeGodine/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAkademskaGodina(int id, AkademskaGodina akademskaGodina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != akademskaGodina.AkademskaGodinaId)
            {
                return BadRequest();
            }

            db.Entry(akademskaGodina).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AkademskaGodinaExists(id))
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

        // POST: api/AkademskeGodine
        [ResponseType(typeof(AkademskaGodina))]
        public IHttpActionResult PostAkademskaGodina(AkademskaGodina akademskaGodina)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.AkademskaGodina.Add(akademskaGodina);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = akademskaGodina.AkademskaGodinaId }, akademskaGodina);
        }

        // DELETE: api/AkademskeGodine/5
        [ResponseType(typeof(AkademskaGodina))]
        public IHttpActionResult DeleteAkademskaGodina(int id)
        {
            AkademskaGodina akademskaGodina = db.AkademskaGodina.Find(id);
            if (akademskaGodina == null)
            {
                return NotFound();
            }

            db.AkademskaGodina.Remove(akademskaGodina);
            db.SaveChanges();

            return Ok(akademskaGodina);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AkademskaGodinaExists(int id)
        {
            return db.AkademskaGodina.Count(e => e.AkademskaGodinaId == id) > 0;
        }
    }
}