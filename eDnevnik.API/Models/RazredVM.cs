using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class RazredVM
    {
        public int RazredId { get; set; }
        public string Naziv { get; set; }
        public string Odjeljenje { get; set; }
        public string RazredOdjeljenje { get; set; }
        public string AkademskaGodina { get; set; }
        public int AkademskaGodinaId { get; set; }
    }
}