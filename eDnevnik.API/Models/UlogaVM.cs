using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class UlogaVM //napravljena nova klasa da bi izbjegli circular relationship
    {
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
    }
}