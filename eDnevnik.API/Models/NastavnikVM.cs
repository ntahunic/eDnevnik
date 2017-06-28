using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class NastavnikVM
    {
        public int NastavnikId { get; set; }
        public string Titula { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        //public Korisnik Korisnik { get; set; }
    }
}