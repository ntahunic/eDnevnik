﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eDnevnik.API.Models
{
    public class PredmetVM
    {
        public int PredmetId { get; set; }
        public string Naziv { get; set; }
        public string AkademskaGodina { get; set; }
        public string Nastavnik { get; set; }
        public string Razred { get; set; }
    }
}