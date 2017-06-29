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
    public class OcjeneMaterijalController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/OcjeneMaterijal/GetOcjeneByMaterialByUcenik/1/1
        [Route("api/OcjeneMaterijal/GetOcjeneByMaterialByUcenik/{materialId}/{ucenikId}")]
        public OcjenaMaterijalVM GetMaterialByPredmet(int materialId, int ucenikId)
        {
            return db.OcjenaMaterijal.Where(y => y.MaterijalId == materialId && y.UcenikId == ucenikId).Select(x => new OcjenaMaterijalVM
            {
                MaterijalId = x.MaterijalId,
                UcenikId = x.UcenikId,
                Datum = x.Datum,
                Materijal = x.Materijal.Naziv,
                OcjenaMaterijalId = x.OcjenaMaterijalId,
                OcjenaVrijednost = x.OcjenaVrijednost,
                Ucenik = x.Ucenik.Korisnik.Ime + " " + x.Ucenik.Korisnik.Prezime
            }).Single();
        }

        
        [ResponseType(typeof(OcjenaMaterijal))]
        public IHttpActionResult PostOcjenaMaterijal(OcjenaMaterijalVM ocjena)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            OcjenaMaterijal ocj = db.OcjenaMaterijal.Where(x => x.OcjenaMaterijalId == ocjena.OcjenaMaterijalId).FirstOrDefault();

            if (ocj == null)
            {
                db.OcjenaMaterijal.Add(new OcjenaMaterijal
                {
                    Datum = ocjena.Datum,
                    MaterijalId = ocjena.MaterijalId,
                    OcjenaVrijednost = ocjena.OcjenaVrijednost,
                    UcenikId = ocjena.UcenikId
                });
                db.SaveChanges();

                return Ok();
            }
            else
            {
                ocj.OcjenaVrijednost = ocjena.OcjenaVrijednost;
                db.SaveChanges();
                return Ok();
            }

        }

    }
}
