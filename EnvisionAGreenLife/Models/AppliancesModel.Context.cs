﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnvisionAGreenLife.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppliancesEntities : DbContext
    {
        public AppliancesEntities()
            : base("name=AppliancesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<air_conditioner> air_conditioner { get; set; }
        public virtual DbSet<appliance_types> appliance_types { get; set; }
        public virtual DbSet<clothes_dryer> clothes_dryer { get; set; }
        public virtual DbSet<clothes_washer> clothes_washer { get; set; }
        public virtual DbSet<dishwasher> dishwashers { get; set; }
        public virtual DbSet<monitor> monitors { get; set; }
        public virtual DbSet<refrigerator> refrigerators { get; set; }
        public virtual DbSet<television> televisions { get; set; }
    }
}