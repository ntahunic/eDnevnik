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
    public class OcjeneController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/Ocjene
        public IQueryable<Ocjena> GetOcjena()
        {
            return db.Ocjena;
        }

        // GET: api/Ocjene/5
        [ResponseType(typeof(Ocjena))]
        public IHttpActionResult GetOcjena(int id)
        {
            OcjenaVM ocjena = db.Ocjena.Where(x => x.OcjenaId == id).Select(y => new OcjenaVM
            {
                CasId = y.CasId,
                OcjenaId = y.OcjenaId,
                OcjenaVrijednost = y.OcjenaVrijednost,
                Ucenik = y.Ucenik.Korisnik.Ime + " " + y.Ucenik.Korisnik.Ime,
                UcenikId = y.UcenikId,
                Datum = y.Cas.Datum
            }).FirstOrDefault();
              
            if (ocjena == null)
            {
                return NotFound();
            }

            return Ok(ocjena);
        }

        // GET: api/Ocjene/GetOcjeneByPredmet/5
        [ResponseType(typeof(Ocjena))]
        [Route("api/Ocjene/GetOcjeneByPredmet/{predmetId}")]
        public IHttpActionResult GetOcjeneByPredmet(int predmetId)
        {
            List<OcjenaVM> ocjene = db.Ocjena.Where(x => x.Cas.PredmetId == predmetId).Select(y=> new OcjenaVM
            {
                CasId = y.CasId,
                OcjenaId = y.OcjenaId,
                OcjenaVrijednost = y.OcjenaVrijednost,
                Ucenik = y.Ucenik.Korisnik.Ime + " " + y.Ucenik.Korisnik.Prezime,
                UcenikId = y.UcenikId,
                Datum = y.Cas.Datum
            }).ToList();
            if (ocjene == null)
            {
                return NotFound();
            }

            return Ok(ocjene);
        }

        // GET: api/Ocjene/GetOcjeneByPredmet/5
        [ResponseType(typeof(Ocjena))]
        [Route("api/Ocjene/GetOcjeneByPredmetByUcenik/{predmetId}/{ucenikId}")]
        public IHttpActionResult GetOcjeneByPredmet(int predmetId, int ucenikId)
        {
            List<OcjenaVM> ocjene = db.Ocjena.Where(x => x.Cas.PredmetId == predmetId && x.UcenikId == ucenikId).Select(y => new OcjenaVM
            {
                CasId = y.CasId,
                OcjenaId = y.OcjenaId,
                OcjenaVrijednost = y.OcjenaVrijednost,
                Ucenik = y.Ucenik.Korisnik.Ime + " " + y.Ucenik.Korisnik.Prezime,
                UcenikId = y.UcenikId,
                Datum = y.Cas.Datum
            }).ToList();
            if (ocjene == null)
            {
                return NotFound();
            }

            return Ok(ocjene);
        }

        // PUT: api/Ocjene/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOcjena(int id, Ocjena ocjena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ocjena.OcjenaId)
            {
                return BadRequest();
            }

            db.Entry(ocjena).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OcjenaExists(id))
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

        // POST: api/Ocjene
        [ResponseType(typeof(Ocjena))]
        public IHttpActionResult PostOcjena(Ocjena ocjena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ocjena.Add(ocjena);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ocjena.OcjenaId }, ocjena);
        }

        // DELETE: api/Ocjene/5
        [ResponseType(typeof(Ocjena))]
        public IHttpActionResult DeleteOcjena(int id)
        {
            Ocjena ocjena = db.Ocjena.Find(id);
            if (ocjena == null)
            {
                return NotFound();
            }

            db.Ocjena.Remove(ocjena);
            db.SaveChanges();

            return Ok(ocjena);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OcjenaExists(int id)
        {
            return db.Ocjena.Count(e => e.OcjenaId == id) > 0;
        }
    }
}