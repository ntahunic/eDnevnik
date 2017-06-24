﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using eDnevnik.API.Models;

namespace eDnevnik.API.Controllers
{
    public class PrisustvoController : ApiController
    {
        private eDnevnikEntities _db = new eDnevnikEntities();

        [Route("api/prisustvo/{casId}")]
        public List<PrisustvoVM> GetPrisustvo(int casId)
        {
            return _db.Prisustvo.Where(i => i.CasId == casId).Select(x=> new PrisustvoVM
            {
                Ime = x.Ucenik.Korisnik.Ime,
                Prezime = x.Ucenik.Korisnik.Prezime,
                UcenikId = x.UcenikId,
                PrisustvoId = x.PrisustvoId, 
                Prisutan = x.Prisutan,
                Razred = x.Ucenik.Razred.Naziv +" - " +x.Ucenik.Razred.Odjeljenje
            }).ToList();
        }

        [Route("api/prisustvo/prisutniUcenici/{casId}")]
        public List<PrisustvoVM> GetPrisutniUcenici(int casId)
        {
            return _db.Prisustvo.Where(i => i.CasId == casId && i.Prisutan==true).Select(x => new PrisustvoVM
            {
                Ime = x.Ucenik.Korisnik.Ime,
                Prezime = x.Ucenik.Korisnik.Prezime,
                UcenikId = x.UcenikId,
                PrisustvoId = x.PrisustvoId,
                Prisutan = x.Prisutan,
                Razred = x.Ucenik.Razred.Naziv + " - " + x.Ucenik.Razred.Odjeljenje,
                ImePrezime = x.Ucenik.Korisnik.Ime + " " + x.Ucenik.Korisnik.Prezime
            }).ToList();
        }

        [Route("api/prisustvo/GetOdsustvoByUcenik/{ucenikId}")]
        public List<PrisustvoVM> GetOdsustvoByUcenik(int ucenikId)
        {
            return _db.Prisustvo.Where(i => i.UcenikId == ucenikId && i.Prisutan == false).Select(x => new PrisustvoVM
            {
                Ime = x.Ucenik.Korisnik.Ime,
                Prezime = x.Ucenik.Korisnik.Prezime,
                UcenikId = x.UcenikId,
                PrisustvoId = x.PrisustvoId,
                Prisutan = x.Prisutan,
                Razred = x.Ucenik.Razred.Naziv + " - " + x.Ucenik.Razred.Odjeljenje,
                ImePrezime = x.Ucenik.Korisnik.Ime + " " + x.Ucenik.Korisnik.Prezime,
                BrojSati = x.Cas.BrojSati,
                Datum = x.Cas.Datum,
                Predmet = x.Cas.Predmet.Naziv,
                Opravdano = x.Opravdano==true?"Opravdano":"Neopravdano"
            }).ToList();
        }




        //public IHttpActionResult PostPrisustvo(Prisustvo obj)
        //{
        //    if (obj == null)
        //        return BadRequest();

        //    _db.Prisustvo.Add(obj);
        //    _db.SaveChanges();
        //    return Ok();
        //}

        [HttpPost]
        public IHttpActionResult PostPrisustvo([FromBody] UceniciWrapper uceniciCas)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            foreach (var ucenik in uceniciCas.Ucenici)
            {
                Prisustvo p = new Prisustvo
                {
                    BrojSati = uceniciCas.Cas.BrojSati,
                    CasId = uceniciCas.Cas.CasId,
                    Prisutan = true,
                    UcenikId = ucenik.UcenikId
                };
                _db.Prisustvo.Add(p);
                _db.SaveChanges();
            }

            return Ok();
        }

        [HttpPut]
        public IHttpActionResult PutPrisustvo([FromBody] Prisustvo prisustvo)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            

            Prisustvo p = _db.Prisustvo.Find(prisustvo.PrisustvoId);
            p.BrojSati = prisustvo.BrojSati;
            p.CasId = prisustvo.CasId;
            p.UcenikId = prisustvo.UcenikId;
            p.Prisutan = prisustvo.Prisutan;
            _db.SaveChanges();
            return StatusCode(HttpStatusCode.NoContent);
        }
    }
}
