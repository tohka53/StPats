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
    
    public partial class Shopping_Cart_StPats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shopping_Cart_StPats()
        {
            this.Bill_StPats = new HashSet<Bill_StPats>();
            this.Shopping_Cart_Detalle_StPats = new HashSet<Shopping_Cart_Detalle_StPats>();
        }
    
        public long id_shoppingcart { get; set; }
        public int id_cliente { get; set; }
        public System.DateTime date { get; set; }
        public decimal monto_sin_taxes { get; set; }
        public decimal taxes { get; set; }
        public decimal monto_total { get; set; }
        public int estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bill_StPats> Bill_StPats { get; set; }
        public virtual Clients_StPats Clients_StPats { get; set; }
        public virtual Estado_StPats Estado_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shopping_Cart_Detalle_StPats> Shopping_Cart_Detalle_StPats { get; set; }
    }
}
