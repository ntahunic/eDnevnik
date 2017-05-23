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
    public class UceniciController : ApiController
    {
        private eDnevnikEntities1 db = new eDnevnikEntities1();

        // GET: api/Ucenici
        public IQueryable<Ucenik> GetUcenik()
        {
            return db.Ucenik;
        }

        // GET: api/Ucenici/5
        [ResponseType(typeof(Ucenik))]
        public IHttpActionResult GetUcenik(int id)
        {
            Ucenik ucenik = db.Ucenik.Find(id);
            if (ucenik == null)
            {
                return NotFound();
            }

            return Ok(ucenik);
        }

        // PUT: api/Ucenici/5
        [ResponseType(typeof(void))]
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
        [ResponseType(typeof(Ucenik))]
        public IHttpActionResult PostUcenik(Ucenik ucenik)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Ucenik.Add(ucenik);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = ucenik.UcenikId }, ucenik);
        }

        // DELETE: api/Ucenici/5
        [ResponseType(typeof(Ucenik))]
        public IHttpActionResult DeleteUcenik(int id)
        {
            Ucenik ucenik = db.Ucenik.Find(id);
            if (ucenik == null)
            {
                return NotFound();
            }

            db.Ucenik.Remove(ucenik);
            db.SaveChanges();

            return Ok(ucenik);
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