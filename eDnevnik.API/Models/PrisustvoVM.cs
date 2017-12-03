using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class PrisustvoVM
    {
        public int PrisustvoId { get; set; }
        public int UcenikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get; set; }
        public string Razred { get; set; }
        public bool? Prisutan { get; set; }
        public bool? IsOpravdano { get; set; }
        public string Opravdano { get; set; }

        public string Datum { get; set; }
        public string Predmet  { get; set; }
        public int BrojSati { get; set; }

        //public int CasId { get; set; }
        //public virtual Cas Cas { get; set; }
        //public int BrojSati { get; set; }
        //public virtual Ucenik Ucenik { get; set; }
    }
}