﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImportJsonData_Demo.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBModel : DbContext
    {
        

        public DBModel()
            : base("name=DBModel")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<customer1>().ToTable("customer1");
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<customer1> customers1 { get; set; }
    }
}
