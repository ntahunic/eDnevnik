using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class OcjenaVM
    {
        public int OcjenaId { get; set; }
        public int OcjenaVrijednost { get; set; }
        public int UcenikId { get; set; }
        public int CasId { get; set; }
        public string Ucenik { get; set; }
    }
}