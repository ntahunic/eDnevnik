using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;

namespace eDnevnik.API.Controllers
{
    public class NastavniciController : ApiController
    {
        private eDnevnikEntities _db = new eDnevnikEntities();

        //api/nastavnici
        public List<NastavnikVM> GetNastavnici()
        {
            return _db.Nastavnik.Select(x => new NastavnikVM()
            {
                NastavnikId = x.NastavnikId,
                Titula = x.Titula,
                Ime = x.Korisnik.Ime,
                Prezime = x.Korisnik.Prezime,
                Username = x.Korisnik.Username,
                Password = x.Korisnik.Password
            }).ToList();
        }

        [Route("api/Nastavnici/{username}")]
        public IHttpActionResult GetNastavnici(string username)
        {
            NastavnikVM n = _db.Nastavnik.Where(x => x.Korisnik.Username == username).Select(y => new NastavnikVM
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
    }
}
