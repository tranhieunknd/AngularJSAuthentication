﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AngularJSAuthentication.ADO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_BusStopEntities : DbContext
    {
        public db_BusStopEntities()
            : base("name=db_BusStopEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bus_cake> bus_cake { get; set; }
        public virtual DbSet<bus_information> bus_information { get; set; }
        public virtual DbSet<bus_location> bus_location { get; set; }
        public virtual DbSet<bus_mabus> bus_mabus { get; set; }
        public virtual DbSet<bus_pointbus> bus_pointbus { get; set; }
    }
}
