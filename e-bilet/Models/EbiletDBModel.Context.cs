﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace e_bilet.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EFEbiletDBEntities2 : DbContext
    {
        public EFEbiletDBEntities2()
            : base("name=EFEbiletDBEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAdmin> tblAdmin { get; set; }
        public virtual DbSet<tblBilet> tblBilet { get; set; }
        public virtual DbSet<tblBolge> tblBolge { get; set; }
        public virtual DbSet<tblEtkinlik> tblEtkinlik { get; set; }
        public virtual DbSet<tblFatura> tblFatura { get; set; }
        public virtual DbSet<tblIletişimBilgileri> tblIletişimBilgileri { get; set; }
        public virtual DbSet<tblKategori> tblKategori { get; set; }
        public virtual DbSet<tblKategoriTuru> tblKategoriTuru { get; set; }
        public virtual DbSet<tblKisi> tblKisi { get; set; }
        public virtual DbSet<tblMusteri> tblMusteri { get; set; }
        public virtual DbSet<tblOdemeTuru> tblOdemeTuru { get; set; }
        public virtual DbSet<tblSiparis> tblSiparis { get; set; }
    }
}
