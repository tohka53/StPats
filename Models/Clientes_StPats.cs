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
    
    public partial class Clientes_StPats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Clientes_StPats()
        {
            this.Shopping_Cart_StPats = new HashSet<Shopping_Cart_StPats>();
        }
    
        public int id_cliente { get; set; }
        public string cliente_nombre { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart_StPats> Shopping_Cart_StPats { get; set; }
    }
}