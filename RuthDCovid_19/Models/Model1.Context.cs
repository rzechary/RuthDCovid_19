//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RuthDCovid_19.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RuthDausDataBaseCovid_19Entities : DbContext
    {
        public RuthDausDataBaseCovid_19Entities()
            : base("name=RuthDausDataBaseCovid_19Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Personal_information_and_information_covid> Personal_information_and_information_covid { get; set; }
    }
}
