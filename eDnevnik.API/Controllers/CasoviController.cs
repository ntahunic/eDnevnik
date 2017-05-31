using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;

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

        public IHttpActionResult PostCas(Cas obj)
        {
            if (obj == null)
                return BadRequest();

            _db.Cas.Add(obj);
            _db.SaveChanges();
            return Ok();

        }
    }
}
