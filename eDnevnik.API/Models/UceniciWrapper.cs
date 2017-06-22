using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class UceniciWrapper
    {
        public Cas Cas { get; set; }
        public List<UcenikVM> Ucenici { get; set; }
    }
}