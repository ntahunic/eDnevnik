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
    public class NastavniciController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/Nastavnici
        public List<NastavnikVM> GetNastavnici()
        {
            return db.Nastavnik.Select(x => new NastavnikVM()
            {
                NastavnikId = x.NastavnikId,
                Titula = x.Titula,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password,
                ImePrezime = x.Korisnik.Ime + " " + x.Korisnik.Prezime
            }).ToList();
        }

        // GET: api/Nastavnici/5
        [ResponseType(typeof(Nastavnik))]
        [Route("api/nastavnici/{id}")]
        public IHttpActionResult GetNastavnik(int id)
        {
            NastavnikVM nastavnik = db.Nastavnik.Where(x => x.NastavnikId == id).Select(x => new NastavnikVM()
            {
                NastavnikId = x.NastavnikId,
                Titula = x.Titula,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password
            }).Single();
            if (nastavnik == null)
            {
                return NotFound();
            }

            return Ok(nastavnik);
        }

        // GET: api/Nastavnici/adil
        [Route("api/Nastavnici/getByUsername/{username}")]
        public IHttpActionResult GetNastavnici(string username)
        {
            NastavnikVM n = db.Nastavnik.Where(x => x.Korisnik.Username == username).Select(y => new NastavnikVM
            {
                Ime = y.Korisnik.Ime,
                Prezime = y.Korisnik.Prezime,
                NastavnikId = y.NastavnikId,
                Password = y.Korisnik.Password,
                Username = y.Korisnik.Username,
                Titula = y.Titula
            }).FirstOrDefault();
            if (n == null)
                return NotFound();
            return Ok(n);
        }

        // PUT: api/Nastavnici/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNastavnik(int id, Nastavnik nastavnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nastavnik.NastavnikId)
            {
                return BadRequest();
            }

            db.Entry(nastavnik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NastavnikExists(id))
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

        // POST: api/Nastavnici
        [ResponseType(typeof(Nastavnik))]
        public IHttpActionResult PostNastavnik(Nastavnik nastavnik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nastavnik.Add(nastavnik);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (NastavnikExists(nastavnik.NastavnikId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = nastavnik.NastavnikId }, nastavnik);
        }

        // DELETE: api/Nastavnici/5
        [ResponseType(typeof(Nastavnik))]
        public IHttpActionResult DeleteNastavnik(int id)
        {
            Nastavnik nastavnik = db.Nastavnik.Find(id);
            if (nastavnik == null)
            {
                return NotFound();
            }

            db.Nastavnik.Remove(nastavnik);
            db.SaveChanges();

            return Ok(nastavnik);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NastavnikExists(int id)
        {
            return db.Nastavnik.Count(e => e.NastavnikId == id) > 0;
        }
    }
}