using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class RasporedCasovaVM
    {
        public int RasporedCasovaId { get; set; }
        public int RazredId { get; set; }
        public string Pon { get; set; }
        public string Uto { get; set; }
        public string Sri { get; set; }
        public string Cet { get; set; }
        public string Pet { get; set; }
    }
}