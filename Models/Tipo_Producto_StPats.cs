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
    
    public partial class Tipo_Producto_StPats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tipo_Producto_StPats()
        {
            this.Productos_StPats = new HashSet<Productos_StPats>();
        }
    
        public int id_tipo_producto { get; set; }
        public string descripcion_producto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Productos_StPats> Productos_StPats { get; set; }
    }
}
