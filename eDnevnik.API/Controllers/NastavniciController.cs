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
            Nastavnik n = _db.Nastavnik.FirstOrDefault(x => x.Korisnik.Username == username);
            if (n == null)
                return NotFound();
            return Ok(n);
        }
    }
}
