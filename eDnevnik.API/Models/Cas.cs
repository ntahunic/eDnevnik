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
    
    public partial class Cas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cas()
        {
            this.Izostanak = new HashSet<Izostanak>();
            this.Ocjena = new HashSet<Ocjena>();
        }
    
        public int CasId { get; set; }
        public string Datum { get; set; }
        public int ProfesorId { get; set; }
        public int PredmetId { get; set; }
    
        public virtual Predmet Predmet { get; set; }
        public virtual Profesor Profesor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Izostanak> Izostanak { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocjena> Ocjena { get; set; }
    }
}
