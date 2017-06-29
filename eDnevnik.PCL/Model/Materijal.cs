using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.PCL.Model
{
    public class Materijal
    {
        public int MaterijalId { get; set; }
        public string Naziv { get; set; }
        public int PredmetId { get; set; }
        
    }
}
