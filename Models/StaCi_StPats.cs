//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StPats.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaCi_StPats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaCi_StPats()
        {
            this.Clients_StPats = new HashSet<Clients_StPats>();
        }
    
        public int id_ciudad_estado { get; set; }
        public int id_estado { get; set; }
        public int id_ciudad { get; set; }
    
        public virtual Ciudades_StPats Ciudades_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Clients_StPats> Clients_StPats { get; set; }
        public virtual State_StPats State_StPats { get; set; }
    }
}