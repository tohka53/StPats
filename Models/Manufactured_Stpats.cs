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
    
    public partial class Manufactured_Stpats
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manufactured_Stpats()
        {
            this.Bottle_Finishing_StPats = new HashSet<Bottle_Finishing_StPats>();
            this.Filling_Machine_StPats = new HashSet<Filling_Machine_StPats>();
            this.Filter_ACF_StPats = new HashSet<Filter_ACF_StPats>();
            this.Filter_CH_StPats = new HashSet<Filter_CH_StPats>();
            this.Filter_PAF_StPats = new HashSet<Filter_PAF_StPats>();
            this.Filter_PES_StPats = new HashSet<Filter_PES_StPats>();
            this.Filter_PP_StPats = new HashSet<Filter_PP_StPats>();
            this.Filter_StPats = new HashSet<Filter_StPats>();
            this.Labeler_StPats = new HashSet<Labeler_StPats>();
            this.Pump_StPats = new HashSet<Pump_StPats>();
            this.Tank_LCBT_VC_ACF_StPats = new HashSet<Tank_LCBT_VC_ACF_StPats>();
            this.Tank_LCTTCB_StPats = new HashSet<Tank_LCTTCB_StPats>();
            this.Tank_LCTTCJ_VC_StPats = new HashSet<Tank_LCTTCJ_VC_StPats>();
            this.Tank_LFBT_VC_StPats = new HashSet<Tank_LFBT_VC_StPats>();
            this.Tank_LFLT_VCCJ_StPats = new HashSet<Tank_LFLT_VCCJ_StPats>();
            this.Tank_LSBT_VC_ACF_StPats = new HashSet<Tank_LSBT_VC_ACF_StPats>();
            this.Tank_LWWFWCJCT_VC_StPats = new HashSet<Tank_LWWFWCJCT_VC_StPats>();
            this.Tank_MXT_StPats = new HashSet<Tank_MXT_StPats>();
            this.Tank_TONW_StPats = new HashSet<Tank_TONW_StPats>();
        }
    
        public int id_manufactured { get; set; }
        public string name_manufactured { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bottle_Finishing_StPats> Bottle_Finishing_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filling_Machine_StPats> Filling_Machine_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter_ACF_StPats> Filter_ACF_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter_CH_StPats> Filter_CH_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter_PAF_StPats> Filter_PAF_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter_PES_StPats> Filter_PES_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter_PP_StPats> Filter_PP_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Filter_StPats> Filter_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Labeler_StPats> Labeler_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pump_StPats> Pump_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LCBT_VC_ACF_StPats> Tank_LCBT_VC_ACF_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LCTTCB_StPats> Tank_LCTTCB_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LCTTCJ_VC_StPats> Tank_LCTTCJ_VC_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LFBT_VC_StPats> Tank_LFBT_VC_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LFLT_VCCJ_StPats> Tank_LFLT_VCCJ_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LSBT_VC_ACF_StPats> Tank_LSBT_VC_ACF_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_LWWFWCJCT_VC_StPats> Tank_LWWFWCJCT_VC_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_MXT_StPats> Tank_MXT_StPats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tank_TONW_StPats> Tank_TONW_StPats { get; set; }
    }
}
