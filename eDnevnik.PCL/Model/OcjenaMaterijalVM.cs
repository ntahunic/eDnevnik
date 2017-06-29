using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.PCL.Model
{
    public class OcjenaMaterijalVM
    {
        public int OcjenaMaterijalId { get; set; }
        public int OcjenaVrijednost { get; set; }
        public string Datum { get; set; }
        public int MaterijalId { get; set; }
        public int UcenikId { get; set; }

        public string Materijal { get; set; }
        public string Ucenik { get; set; }
    }
}
