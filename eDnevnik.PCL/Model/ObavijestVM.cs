using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.PCL.Model
{
    public class ObavijestVM
    {
        public int ObavijestId { get; set; }
        public string Naslov { get; set; }
        public string Sadrzaj { get; set; }
        public string Nastavnik { get; set; }
        public int NastavnikId { get; set; }
        public string Predmet { get; set; }
        public int PredmetId { get; set; }
        public string Datum { get; set; }
    }
}
