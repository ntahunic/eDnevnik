using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.PCL.Model
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
        public string Opravdano { get; set; }


        public string Datum { get; set; }
        public string Predmet { get; set; }
        public int BrojSati { get; set; }
    }
}
