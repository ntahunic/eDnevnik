using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;
using System.Web.Http.Description;

namespace eDnevnik.API.Controllers
{
    public class CasoviController : ApiController
    {
        private eDnevnikEntities _db = new eDnevnikEntities();

        public List<CasVM> GetCasovi()
        {
            return _db.Cas.Select(x => new CasVM
            {
                CasId = x.CasId,
                Nastavnik = x.Nastavnik.Korisnik.Ime + " " +x.Nastavnik.Korisnik.Prezime,
                Predmet = x.Predmet.Naziv,
                Datum = x.Datum,
                BrojSati = x.BrojSati
            }).ToList();
        }

        // GET: api/Ocjene/5
        [ResponseType(typeof(Cas))]
        public IHttpActionResult GetCas(int id)
        {
            CasVM cas = _db.Cas.Where(x => x.CasId == id).Select(x => new CasVM
            {
                CasId = x.CasId,
                Nastavnik = x.Nastavnik.Korisnik.Ime + " " + x.Nastavnik.Korisnik.Prezime,
                Predmet = x.Predmet.Naziv,
                Datum = x.Datum,
                BrojSati = x.BrojSati
            }).FirstOrDefault();

            if (cas == null)
            {
                return NotFound();
            }

            return Ok(cas);
        }

        public IHttpActionResult PostCas(Cas obj)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                _db.Cas.Add(obj);
                _db.SaveChanges();
            }
            catch (EntityException e)
            {
                throw CreateHttpResponseException(Util.ExceptionHandler.HandleException(e), HttpStatusCode.Conflict);
            }
            
            return CreatedAtRoute("DefaultApi", new {id = obj.CasId} , obj);
        }

        private HttpResponseException CreateHttpResponseException(string reason, HttpStatusCode code)
        {
            HttpResponseMessage msg = new HttpResponseMessage
            {
                StatusCode = code,
                ReasonPhrase = reason,
                Content = new StringContent(reason)
            };

            return new HttpResponseException(msg);
        }
    }
}
