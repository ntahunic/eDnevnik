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
    
    public partial class Razred
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Razred()
        {
            this.Ucenik = new HashSet<Ucenik>();
        }
    
        public int RazredId { get; set; }
        public string Naziv { get; set; }
        public string Odjeljenje { get; set; }
        public int AkademskaGodinaId { get; set; }
    
        public virtual AkademskaGodina AkademskaGodina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ucenik> Ucenik { get; set; }
    }
}
