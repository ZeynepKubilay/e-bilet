using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using e_bilet.Models.tablolar;

namespace e_bilet.Models.Managers
{
    public class DatabaseContext : DbContext
    {
        public DbSet<tblAdmin> Admin { get; set; }
        public DbSet<tblBilet> Bilets { get; set; }
        public DbSet<tblBolge> Bolge { get; set; }
        public DbSet<tblEtkinlik> Etkinlik { get; set; }
        public DbSet<tblFatura> Fatura { get; set; }
        public DbSet<tblIletişimBilgileri> IletisimBilgileri { get; set; }
        public DbSet<tblKategori> Kategori { get; set; }
        public DbSet<tblKategoriTuru> KategoriTuru { get; set; }
        public DbSet<tblKisi> Kisi { get; set; }
        public DbSet<tblMusteri> Musteri { get; set; }
        public DbSet<tblOdemeTuru> OdemeTuru { get; set; }
        public DbSet<tblSiparis> Siparis { get; set; }

        public DatabaseContext()
        {
            Database.SetInitializer(new MyDbContext());
        }
    }
}