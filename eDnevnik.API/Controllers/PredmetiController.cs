using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using eDnevnik.API.Models;
using System.Web.Http.Description;
using System.Data.Entity.Infrastructure;
using System.Data.Entity;

namespace eDnevnik.API.Controllers
{
    public class PredmetiController : ApiController
    {
        private eDnevnikEntities db = new eDnevnikEntities();

        // GET: api/Predmeti
        public List<PredmetVM> GetPredmeti()
        {
            return db.Predmet.Select(x => new PredmetVM()
            {
                Naziv = x.Naziv,
                PredmetId = x.PredmetId,
                AkademskaGodina = x.AkademskaGodina.Naziv,
                Razred = x.Razred.Naziv,
                AkademskaGodinaId = x.AkademskaGodinaId,
                Nastavnici = x.Nastavnik.Select(n => new NastavnikVM
                {
                    Ime = n.Korisnik.Ime,
                    Prezime = n.Korisnik.Prezime,
                    ImePrezime = n.Korisnik.Ime+ " "+n.Korisnik.Prezime,
                    NastavnikId = n.Korisnik.KorisnikId,
                    Username = n.Korisnik.Username,
                    Password = n.Korisnik.Password,
                    Titula = n.Titula,
                    Uloge = n.Korisnik.Uloga.Select(u=> new UlogaVM
                    {
                        Naziv = u.Naziv,
                        UlogaId = u.UlogaId
                    }).ToList(),
                }).ToList(),
                RazredId = x.RazredId
            }).ToList();
        }

        // GET: api/Predmeti/5
        [ResponseType(typeof(PredmetVM))]
        public IHttpActionResult GetPredmet(int id)
        {
            PredmetVM predmet = db.Predmet.Where(x => x.PredmetId == id).Select(x => new PredmetVM()
            {
                Naziv = x.Naziv,
                PredmetId = x.PredmetId,
                AkademskaGodina = x.AkademskaGodina.Naziv,
                Razred = x.Razred.Naziv,
                AkademskaGodinaId = x.AkademskaGodinaId,
                RazredId = x.RazredId,
                Nastavnici = x.Nastavnik.Select(n => new NastavnikVM
                {
                    Ime = n.Korisnik.Ime,
                    Prezime = n.Korisnik.Prezime,
                    ImePrezime = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                    NastavnikId = n.Korisnik.KorisnikId,
                    Username = n.Korisnik.Username,
                    Password = n.Korisnik.Password,
                    Titula = n.Titula,
                    Uloge = n.Korisnik.Uloga.Select(u => new UlogaVM
                    {
                        Naziv = u.Naziv,
                        UlogaId = u.UlogaId
                    }).ToList(),
                }).ToList(),
            }).Single();
            if (predmet == null)
            {
                return NotFound();
            }

            return Ok(predmet);
        }

        [HttpGet]
        [Route("api/Predmeti/getPredmetiByNastavnik/{nastavnikId}")]
        public IHttpActionResult GetPredmetiByNastavnik(int nastavnikId)
        {
            List<PredmetVM> predmeti = new List<PredmetVM>();
            foreach (var p in db.Predmet.Where(p=>p.Nastavnik.Any(n=>n.NastavnikId == nastavnikId)))
            {
                predmeti.Add(new PredmetVM
                {
                    Naziv = p.Naziv,
                    PredmetId = p.PredmetId,
                    AkademskaGodina = p.AkademskaGodina.Naziv,
                    Razred = p.Razred.Naziv,
                    Nastavnici = p.Nastavnik.Select(n => new NastavnikVM
                    {
                        Ime = n.Korisnik.Ime,
                        Prezime = n.Korisnik.Prezime,
                        ImePrezime = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                        NastavnikId = n.Korisnik.KorisnikId,
                        Username = n.Korisnik.Username,
                        Password = n.Korisnik.Password,
                        Titula = n.Titula,
                        Uloge = n.Korisnik.Uloga.Select(u => new UlogaVM
                        {
                            Naziv = u.Naziv,
                            UlogaId = u.UlogaId
                        }).ToList(),
                    }).ToList(),
                });
            }
            //List<PredmetVM> predmeti = db.Predmet.Where(p=>p.Nastavnik.Where(y=>y.NastavnikId == nastavnikId).Select(x => new PredmetVM()
            //{
            //    Naziv = p.Naziv,
            //    PredmetId = p.PredmetId,
            //    AkademskaGodina = p.AkademskaGodina.Naziv,
            //    Razred = p.Razred.Naziv,
            //    Nastavnici = p.Nastavnik.Select(n => new NastavnikVM
            //    {
            //        Ime = n.Korisnik.Ime,
            //        Prezime = n.Korisnik.Prezime,
            //        ImePrezime = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
            //        NastavnikId = n.Korisnik.KorisnikId,
            //        Username = n.Korisnik.Username,
            //        Password = n.Korisnik.Password,
            //        Titula = n.Titula,
            //        Uloge = n.Korisnik.Uloga.Select(u => new UlogaVM
            //        {
            //            Naziv = u.Naziv,
            //            UlogaId = u.UlogaId
            //        }).ToList(),
            //    }).ToList(),
            //}).ToList());

            if (predmeti == null)
                return NotFound();
            return Ok(predmeti);
        }

        [HttpGet]
        [Route("api/Predmeti/getPredmetiByRazred/{razredId}")]
        public IHttpActionResult GetPredmetiByRazred(int razredId)
        {
            List<PredmetVM> predmeti = db.Predmet.Where(y => y.RazredId == razredId).Select(x => new PredmetVM()
            {
                Naziv = x.Naziv,
                PredmetId = x.PredmetId,
                AkademskaGodina = x.AkademskaGodina.Naziv,
                Nastavnici = x.Nastavnik.Select(n => new NastavnikVM
                {
                    Ime = n.Korisnik.Ime,
                    Prezime = n.Korisnik.Prezime,
                    ImePrezime = n.Korisnik.Ime + " " + n.Korisnik.Prezime,
                    NastavnikId = n.Korisnik.KorisnikId,
                    Username = n.Korisnik.Username,
                    Password = n.Korisnik.Password,
                    Titula = n.Titula,
                    Uloge = n.Korisnik.Uloga.Select(u => new UlogaVM
                    {
                        Naziv = u.Naziv,
                        UlogaId = u.UlogaId
                    }).ToList(),
                }).ToList(),
                Razred = x.Razred.Naziv
            }).ToList();

            if (predmeti == null)
                return NotFound();
            return Ok(predmeti);
        }

        // PUT: api/Predmeti/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPredmet(int id, Predmet predmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != predmet.PredmetId)
            {
                return BadRequest();
            }

            db.Entry(predmet).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PredmetExists(id))
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

        [HttpPut]
        [Route("api/Predmeti/putPredmetNewNastavnik/{predmetId}/{nastavnikId}")]
        public IHttpActionResult PutPredmet(int predmetId, int nastavnikId, Predmet obj)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Nastavnik nastavnik = db.Nastavnik.Where(n => n.NastavnikId == nastavnikId).FirstOrDefault();
            Predmet predmet = db.Predmet.Where(p => p.PredmetId == predmetId).FirstOrDefault();

            if (predmet != null)
                predmet.Nastavnik.Add(nastavnik);

            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Predmeti
        [ResponseType(typeof(Predmet))]
        public IHttpActionResult PostPredmet(Predmet predmet)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Predmet.Add(predmet);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = predmet.PredmetId }, predmet);
        }

        // DELETE: api/Predmeti/5
        [ResponseType(typeof(Predmet))]
        public IHttpActionResult DeletePredmet(int id)
        {
            Predmet predmet = db.Predmet.Find(id);
            if (predmet == null)
            {
                return NotFound();
            }

            db.Predmet.Remove(predmet);
            db.SaveChanges();

            return Ok(predmet);
        }

        [Route("api/Predmeti/deletePredmetNewNastavnik/{predmetId}/{nastavnikId}")]
        public IHttpActionResult DeletePredmet(int predmetId, int nastavnikId)
        {
            Nastavnik nastavnik = db.Nastavnik.Where(n => n.NastavnikId == nastavnikId).FirstOrDefault();
            Predmet predmet = db.Predmet.Where(p => p.PredmetId == predmetId).FirstOrDefault();

            if (predmet == null)
            {
                return NotFound();
            }

            if (predmet != null)
            {
                predmet.Nastavnik.Remove(nastavnik);
                nastavnik.Predmet.Remove(predmet);
            }

            db.SaveChanges();

            return Ok();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PredmetExists(int id)
        {
            return db.Predmet.Count(e => e.PredmetId == id) > 0;
        }
    }
}
