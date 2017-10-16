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
    public class RasporedCasovaController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/RasporedCasova
        public IQueryable<RasporedCasovaVM> GetRasporedCasova()
        {
            return db.RasporedCasova.Select(r => new RasporedCasovaVM
            {
                RasporedCasovaId = r.RasporedCasovaId,
                RazredId = r.RazredId,
                Pon = r.Pon,
                Uto = r.Uto,
                Sri = r.Sri,
                Cet = r.Cet,
                Pet = r.Pet
            });
        }

        //// GET: api/RasporedCasova/5
        //[ResponseType(typeof(RasporedCasova))]
        //public IHttpActionResult GetRasporedCasova(int id)
        //{
        //    RasporedCasova rasporedCasova = db.RasporedCasova.Find(id);
        //    if (rasporedCasova == null)
        //    {
        //        return NotFound();
        //    }

        //    return Ok(rasporedCasova);
        //}

        [Route("api/RasporedCasova/getByRazred/{razredId}")]
        public RasporedCasovaVM GetRasporedCasova(int razredId)
        {
            return db.RasporedCasova.Where(x => x.RazredId == razredId).Select(r => new RasporedCasovaVM
            {
                RasporedCasovaId = r.RasporedCasovaId,
                RazredId = r.RazredId,
                Pon = r.Pon,
                Uto = r.Uto,
                Sri = r.Sri,
                Cet = r.Cet,
                Pet = r.Pet
            }).FirstOrDefault();
        }

        // PUT: api/RasporedCasova/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutRasporedCasova(int id, RasporedCasova rasporedCasova)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != rasporedCasova.RasporedCasovaId)
            {
                return BadRequest();
            }

            db.Entry(rasporedCasova).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RasporedCasovaExists(id))
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

        // POST: api/RasporedCasova
        [ResponseType(typeof(RasporedCasova))]
        public IHttpActionResult PostRasporedCasova(RasporedCasova rasporedCasova)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.RasporedCasova.Add(rasporedCasova);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = rasporedCasova.RasporedCasovaId }, rasporedCasova);
        }

        // DELETE: api/RasporedCasova/5
        [ResponseType(typeof(RasporedCasova))]
        public IHttpActionResult DeleteRasporedCasova(int id)
        {
            RasporedCasova rasporedCasova = db.RasporedCasova.Find(id);
            if (rasporedCasova == null)
            {
                return NotFound();
            }

            db.RasporedCasova.Remove(rasporedCasova);
            db.SaveChanges();

            return Ok(rasporedCasova);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool RasporedCasovaExists(int id)
        {
            return db.RasporedCasova.Count(e => e.RasporedCasovaId == id) > 0;
        }
    }
}