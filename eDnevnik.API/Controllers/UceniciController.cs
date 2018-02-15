using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;
using System.Web.Http.Description;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace eDnevnik.API.Controllers
{
    public class UceniciController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        public List<UcenikVM> GetUcenici()
        {
            return db.Ucenik.Select(x => new UcenikVM()
            {
                UcenikId = x.UcenikId,
                Razred = x.Razred.Naziv + " - " + x.Razred.Odjeljenje,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password,
                ImePrezime = x.Korisnik.Ime + " " +x.Korisnik.Prezime,    
                RazredId = x.RazredId,
                Aktivan = x.Korisnik.Aktivan
            }).ToList();
        }

        [Route("api/Ucenici/GetUcenikByUsername/{username}")]
        public IHttpActionResult GetUcenici(string username)
        {
            UcenikVM n = db.Ucenik.Where(x => x.Korisnik.Username == username).Select(y => new UcenikVM
            {
                Ime = y.Korisnik.Ime,
                Prezime = y.Korisnik.Prezime,
                UcenikId = y.UcenikId,
                Password = y.Korisnik.Password,
                Username = y.Korisnik.Username,
                Razred = y.Razred.Naziv,
                RazredId = y.RazredId,
                Aktivan = y.Korisnik.Aktivan,
            }).FirstOrDefault();

            if (n == null)
                return NotFound();
            return Ok(n);
        }

        [Route("api/Ucenici/GetUceniciByRazred/{razredId}")]
        public List<UcenikVM> GetUceniciByRazred(int razredId)
        {
            return db.Ucenik.Where(x => x.RazredId == razredId).Select(y => new UcenikVM
            {
                Ime = y.Korisnik.Ime,
                Prezime = y.Korisnik.Prezime,
                UcenikId = y.UcenikId,
                Password = y.Korisnik.Password,
                Username = y.Korisnik.Username,
                Razred = y.Razred.Naziv,
                RazredId = y.RazredId,
                Aktivan = y.Korisnik.Aktivan,
            }).ToList();
        }

        // GET: api/Ucenici/5
        [ResponseType(typeof(UcenikVM))]
        public IHttpActionResult GetUcenik(int id)
        {
            UcenikVM ucenik = db.Ucenik.Where(x => x.UcenikId == id).Select(x => new UcenikVM()
            {
                UcenikId = x.UcenikId,
                Razred = x.Razred.Naziv + " - " + x.Razred.Odjeljenje,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password,
                ImePrezime = x.Korisnik.Ime + " " + x.Korisnik.Prezime,
                RazredId = x.RazredId,
                Aktivan = x.Korisnik.Aktivan,
            }).Single();

            if (ucenik == null)
            {
                return NotFound();
            }

            return Ok(ucenik);
        }

        // GET: api/Ucenici/GetUcenikByStr/string
        [HttpGet]
        [ResponseType(typeof(UcenikVM))]
        [Route("api/Ucenici/GetUcenikByStr/{searchString?}")]
        public IHttpActionResult GetUcenikByStr(string searchString = "")
        {
            List<UcenikVM> ucenici = db.Ucenik.Where(y => y.Korisnik.Ime.Contains(searchString) || y.Korisnik.Prezime.Contains(searchString) || String.IsNullOrEmpty(searchString)).Select(x => new UcenikVM()
            {
                UcenikId = x.UcenikId,
                Razred = x.Razred.Naziv + " - " + x.Razred.Odjeljenje,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password,
                Aktivan = x.Korisnik.Aktivan,
            }).ToList();

            if (ucenici == null)
            {
                return Conflict();
            }

            return Ok(ucenici);
        }

        // PUT: api/Ucenici/5
        [ResponseType(typeof(void))]
        [HttpPut]
        public IHttpActionResult PutUcenik(int id, Ucenik ucenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != ucenik.UcenikId)
            {
                return BadRequest();
            }

            db.Entry(ucenik).State = EntityState.Modified;
            db.Entry(ucenik.Korisnik).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UcenikExists(id))
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

        // POST: api/Ucenici
        [HttpPost]
        [ResponseType(typeof(Ucenik))]
        public IHttpActionResult PostUcenik(Ucenik ucenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ucenik.Add(ucenik);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UcenikExists(ucenik.UcenikId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = ucenik.UcenikId }, ucenik);
        }

        // DELETE: api/Ucenici/5
        [HttpDelete]
        [ResponseType(typeof(Ucenik))]
        [Route("api/Ucenici/deleteUcenik/{id}")]
        public IHttpActionResult DeleteUcenik(int id)
        {
            //Ucenik ucenik = db.Ucenik.Find(id);
            //if (ucenik == null)
            //{
            //    return NotFound();
            //}

            //db.Ucenik.Remove(ucenik);
            //db.SaveChanges();

            //return Ok();

            Ucenik ucenik = db.Ucenik.Where(x => x.UcenikId == id).FirstOrDefault();

            if (ucenik == null)
            {
                return NotFound();
            }

            ucenik.Korisnik.Aktivan = !ucenik.Korisnik.Aktivan;
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

        private bool UcenikExists(int id)
        {
            return db.Ucenik.Count(e => e.UcenikId == id) > 0;
        }
    }
}
