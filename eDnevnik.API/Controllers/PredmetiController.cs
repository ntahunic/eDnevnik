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


        [HttpGet]
        [Route("api/Predmeti/getPredmetiByNastavnik/{nastavnikId}")]
        public IHttpActionResult GetPredmeti(int nastavnikId)
        {
            List<PredmetVM> predmeti =_db.Predmet.Where(y=>y.NastavnikId == nastavnikId).Select(x => new PredmetVM()
            {
                Naziv = x.Naziv,
                PredmetId = x.PredmetId
            }).ToList();

            if (predmeti == null)
                return NotFound();
            return Ok(predmeti);
        }
    }
}
