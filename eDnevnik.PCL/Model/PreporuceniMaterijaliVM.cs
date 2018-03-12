using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eDnevnik.PCL.Model
{
    public class PreporuceniMaterijaliVM
    {
        public List<MaterijalVM> SlicniMaterijali { get; set; }
        public List<MaterijalVM> PopularniMaterijali { get; set; }
    }
}
