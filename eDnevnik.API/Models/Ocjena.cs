//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eDnevnik.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ocjena
    {
        public int OcjenaId { get; set; }
        public int OcjenaVrijednost { get; set; }
        public int UcenikId { get; set; }
        public int CasId { get; set; }
    
        public virtual Cas Cas { get; set; }
        public virtual Ucenik Ucenik { get; set; }
    }
}
