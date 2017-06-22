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
    public class ObavijestiController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/Obavijesti
        public IQueryable<ObavijestVM> GetObavijest()
        {
            return db.Obavijest.Select(x => new ObavijestVM
            {
                ObavijestId = x.ObavijestId,
                Naslov = x.Naslov,
                Sadrzaj = x.Sadrzaj,
                Datum = x.Datum,
                Nastavnik = x.Nastavnik.Korisnik.Ime + " " +x.Nastavnik.Korisnik.Prezime,
                NastavnikId = x.NastavnikId,
                Predmet = x.Predmet.Naziv,
                PredmetId = x.PredmetId
            });
        }

        // GET: api/Obavijesti/5
        [ResponseType(typeof(Obavijest))]
        public IHttpActionResult GetObavijest(int id)
        {
            ObavijestVM obavijest = db.Obavijest.Where(x => x.ObavijestId == id).Select(y => new ObavijestVM
            {
                ObavijestId = y.ObavijestId,
                Datum = y.Datum,
                Naslov = y.Naslov,
                NastavnikId = y.NastavnikId,
                PredmetId = y.PredmetId,
                Nastavnik = y.Nastavnik.Korisnik.Ime + " " + y.Nastavnik.Korisnik.Prezime,
                Predmet = y.Predmet.Naziv,
                Sadrzaj = y.Sadrzaj
            }).Single();
            
            if (obavijest == null)
            {
                return NotFound();
            }

            return Ok(obavijest);
        }

        // PUT: api/Obavijesti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutObavijest(int id, Obavijest obavijest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != obavijest.ObavijestId)
            {
                return BadRequest();
            }

            db.Entry(obavijest).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ObavijestExists(id))
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

        // POST: api/Obavijesti
        [ResponseType(typeof(Obavijest))]
        public IHttpActionResult PostObavijest(Obavijest obavijest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Obavijest.Add(obavijest);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ObavijestExists(obavijest.ObavijestId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = obavijest.ObavijestId }, obavijest);
        }

        // DELETE: api/Obavijesti/5
        [ResponseType(typeof(Obavijest))]
        public IHttpActionResult DeleteObavijest(int id)
        {
            Obavijest obavijest = db.Obavijest.Find(id);
            if (obavijest == null)
            {
                return NotFound();
            }

            db.Obavijest.Remove(obavijest);
            db.SaveChanges();

            return Ok(obavijest);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ObavijestExists(int id)
        {
            return db.Obavijest.Count(e => e.ObavijestId == id) > 0;
        }
    }
}