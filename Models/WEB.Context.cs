﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StPatsWEB_dbEntities : DbContext
    {
        public StPatsWEB_dbEntities()
            : base("name=StPatsWEB_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bill_StPats> Bill_StPats { get; set; }
        public virtual DbSet<Bottle_Finishing_StPats> Bottle_Finishing_StPats { get; set; }
        public virtual DbSet<Ciudades_StPats> Ciudades_StPats { get; set; }
        public virtual DbSet<Clients_StPats> Clients_StPats { get; set; }
        public virtual DbSet<Estado_StPats> Estado_StPats { get; set; }
        public virtual DbSet<Filling_Machine_StPats> Filling_Machine_StPats { get; set; }
        public virtual DbSet<Filter_ACF_StPats> Filter_ACF_StPats { get; set; }
        public virtual DbSet<Filter_CH_StPats> Filter_CH_StPats { get; set; }
        public virtual DbSet<Filter_PAF_StPats> Filter_PAF_StPats { get; set; }
        public virtual DbSet<Filter_PES_StPats> Filter_PES_StPats { get; set; }
        public virtual DbSet<Filter_PP_StPats> Filter_PP_StPats { get; set; }
        public virtual DbSet<Filter_StPats> Filter_StPats { get; set; }
        public virtual DbSet<Filtros_StPats> Filtros_StPats { get; set; }
        public virtual DbSet<Labeler_StPats> Labeler_StPats { get; set; }
        public virtual DbSet<Lista_Productos_StPats> Lista_Productos_StPats { get; set; }
        public virtual DbSet<Locations_StPats> Locations_StPats { get; set; }
        public virtual DbSet<Manufactured_Stpats> Manufactured_Stpats { get; set; }
        public virtual DbSet<PayMet_StPats> PayMet_StPats { get; set; }
        public virtual DbSet<Productos_StPats> Productos_StPats { get; set; }
        public virtual DbSet<Pump_StPats> Pump_StPats { get; set; }
        public virtual DbSet<Shopping_Cart_Detalle_StPats> Shopping_Cart_Detalle_StPats { get; set; }
        public virtual DbSet<Shopping_Cart_StPats> Shopping_Cart_StPats { get; set; }
        public virtual DbSet<StaCi_StPats> StaCi_StPats { get; set; }
        public virtual DbSet<Statax_StPats> Statax_StPats { get; set; }
        public virtual DbSet<State_StPats> State_StPats { get; set; }
        public virtual DbSet<Tank_LCBT_VC_ACF_StPats> Tank_LCBT_VC_ACF_StPats { get; set; }
        public virtual DbSet<Tank_LCTTCB_StPats> Tank_LCTTCB_StPats { get; set; }
        public virtual DbSet<Tank_LCTTCJ_VC_StPats> Tank_LCTTCJ_VC_StPats { get; set; }
        public virtual DbSet<Tank_LFBT_VC_StPats> Tank_LFBT_VC_StPats { get; set; }
        public virtual DbSet<Tank_LFLT_VCCJ_StPats> Tank_LFLT_VCCJ_StPats { get; set; }
        public virtual DbSet<Tank_LSBT_VC_ACF_StPats> Tank_LSBT_VC_ACF_StPats { get; set; }
        public virtual DbSet<Tank_LWWFWCJCT_VC_StPats> Tank_LWWFWCJCT_VC_StPats { get; set; }
        public virtual DbSet<Tank_MXT_StPats> Tank_MXT_StPats { get; set; }
        public virtual DbSet<Tank_TONW_StPats> Tank_TONW_StPats { get; set; }
        public virtual DbSet<Tanks_StPats> Tanks_StPats { get; set; }
        public virtual DbSet<Tipo_Producto_StPats> Tipo_Producto_StPats { get; set; }
        public virtual DbSet<Type_Filter_StPats> Type_Filter_StPats { get; set; }
        public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
    }
}
