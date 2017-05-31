using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;

namespace eDnevnik.API.Controllers
{
    public class PredmetiController : ApiController
    {
        private eDnevnikEntities _db = new eDnevnikEntities();

        //api/nastavnici
        public List<PredmetVM> GetPredmeti()
        {
            return _db.Predmet.Select(x => new PredmetVM()
            {
                Naziv = x.Naziv,
                PredmetId = x.PredmetId
            }).ToList();
        }
    }
}
