using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;

namespace eDnevnik.API.Controllers
{
    public class UceniciController : ApiController
    {
        private eDnevnikEntities _db = new eDnevnikEntities();

        public List<UcenikVM> GetUcenici()
        {
            return _db.Ucenik.Select(x => new UcenikVM()
            {
                UcenikId = x.UcenikId,
                Ime = x.Ime,
                Prezime = x.Prezime,
                Razred = x.Razred.Naziv + " - " + x.Razred.Odjeljenje
            }).ToList();
        }
    }
}
