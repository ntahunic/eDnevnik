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
                Telefon = x.Telefon,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password,
                ImePrezime = x.Korisnik.Ime + " " + x.Korisnik.Prezime,
                Uloge = x.Korisnik.Uloga.Select(u => new UlogaVM
                {
                    UlogaId = u.UlogaId,
                    Naziv = u.Naziv
                }).ToList()
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
                Telefon = x.Telefon,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password,
                Uloge = x.Korisnik.Uloga.Select(u => new UlogaVM
                {
                    UlogaId = u.UlogaId,
                    Naziv = u.Naziv
                }).ToList()
                //isAdmin = x.Korisnik.IsAdmin
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
                Titula = y.Titula,
                Uloge = y.Korisnik.Uloga.Select(u => new UlogaVM
                {
                    UlogaId = u.UlogaId,
                    Naziv = u.Naziv
                }).ToList()
                //isAdmin= y.Korisnik.IsAdmin
            }).FirstOrDefault();
            if (n == null)
                return NotFound();
            return Ok(n);
        }

        // GET: api/Nastavnici/ooad
        [HttpGet]
        [Route("api/Nastavnici/getNastavniciByPredmet/{predmetId}")]
        public IHttpActionResult GetNastavnici(int predmetId)
        {
            List<NastavnikVM> nastavnici = db.Nastavnik.Where(n => n.Predmet.Any(p => p.PredmetId == predmetId))
                .Select(x => new NastavnikVM
                {
                    Ime = x.Korisnik.Ime,
                    Prezime = x.Korisnik.Prezime,
                    Titula = x.Titula,
                    NastavnikId = x.NastavnikId
                }).ToList();

            foreach (var item in nastavnici)
            {

            }

            //NastavnikVM nastavnik = db.Nastavnik.Where(x => x.Korisnik.Username == username).Select(y => new NastavnikVM
            //{
            //    Ime = y.Korisnik.Ime,
            //    Prezime = y.Korisnik.Prezime,
            //    NastavnikId = y.NastavnikId,
            //    Password = y.Korisnik.Password,
            //    Username = y.Korisnik.Username,
            //    Titula = y.Titula,
            //    Uloge = y.Korisnik.Uloga.Select(u => new UlogaVM
            //    {
            //        UlogaId = u.UlogaId,
            //        Naziv = u.Naziv
            //    }).ToList()
            //    //isAdmin= y.Korisnik.IsAdmin
            //}).FirstOrDefault();
            if (nastavnici == null)
                return Conflict();
            return Ok(nastavnici);
        }

        // PUT: api/Nastavnici/5
        [ResponseType(typeof(void))]
        [Route("api/Nastavnici/putNastavnik/{id}")]
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
            db.Entry(nastavnik.Korisnik).State = EntityState.Modified;
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
        [HttpDelete]
        [Route("api/Nastavnici/deleteNastavnik/{id}")]
        public IHttpActionResult DeleteNastavnik(int id)
        {
            Nastavnik nastavnik = db.Nastavnik.Find(id);
            if (nastavnik == null)
            {
                return NotFound();
            }

            db.Nastavnik.Remove(nastavnik);
            db.SaveChanges();

            return Ok();
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