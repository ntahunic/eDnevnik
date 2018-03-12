using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class PreporuceniMaterijaliVM
    {
        public List<MaterijalVM> SlicniMaterijali { get; set; }
        public List<MaterijalVM> PopularniMaterijali { get; set; }
    }
}