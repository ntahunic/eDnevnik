using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.PCL.Model
{
    public class OcjenaVM
    {
        public int OcjenaId { get; set; }
        public int OcjenaVrijednost { get; set; }
        public int UcenikId { get; set; }
        public int CasId { get; set; }
        public string Ucenik { get; set; }
        public string Datum { get; set; }

    }
}
