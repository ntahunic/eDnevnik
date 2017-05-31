using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class CasVM
    {
        public int CasId { get; set; }
        public string Datum { get; set; }
        public string Nastavnik { get; set; }
        public string Predmet { get; set; }
        public int BrojSati { get; set; }
    }
}