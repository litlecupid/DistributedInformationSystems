﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DistributedInformationSystems
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EnrollmentsEntities1 : DbContext
    {
        public EnrollmentsEntities1()
            : base("name=EnrollmentsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<SchoolYear> SchoolYears { get; set; }
        public DbSet<StudetnCompositionByYear> StudetnCompositionByYears { get; set; }
    }
}
