using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class PredmetVM
    {
        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public string AkademskaGodina { get; set; }
        public int? AkademskaGodinaId { get; set; }
        public string Nastavnik { get; set; }
        public int? NastavnikId { get; set; }
        public string Razred { get; set; }
        public int? RazredId { get; set; }
    }
}