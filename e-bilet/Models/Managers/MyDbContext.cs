using e_bilet.Models.tablolar;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace e_bilet.Models.Managers
{
    public class MyDbContext : CreateDatabaseIfNotExists<DatabaseContext>
    {
        public DbSet<tblAdmin> Admins { get; set; }
        public DbSet<tblBilet> Bilets { get; set; }
        public DbSet<tblBolge> Bolges { get; set; }
        public DbSet<tblEtkinlik> Etkinliks { get; set; }
        public DbSet<tblFatura> Faturas { get; set; }
        public DbSet<tblIletişimBilgileri> IletisimBilgileris { get; set; }
        public DbSet<tblKategori> Kategoris { get; set; }
        public DbSet<tblKategoriTuru> KategoriTurus { get; set; }
        public DbSet<tblKisi> Kisis { get; set; }
        public DbSet<tblMusteri> Musteris { get; set; }
        public DbSet<tblOdemeTuru> OdemeTurus { get; set; }
        public DbSet<tblSiparis> Sipariss { get; set; }


        public override void InitializeDatabase(DatabaseContext context)
        {
            base.InitializeDatabase(context);
        }

    }

    public class Admin
    {
        public int KisiNo { get; set; }
        public int KimlikNo { get; set; }
    }
    public class Bolge
    {
        public int BolgeNo { get; set; }
        public string Il { get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
    }
    public class Etkinlik
    {
        public int EtkinlikID { get; set; }
        public string EtkinlikAdı { get; set; }
        public int KategoriID { get; set; }
        public int BolgeNo { get; set; }
        public DateTime Saat { get; set; }
        public DateTime Tarih { get; set; }
    }
    public class Fatura
    {
        public int FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string OdemeTuru { get; set; }
    }
    public class IletisimBilgileri
    {
        public int No { get; set; }
        public int TelefonNumarasi { get; set; }
        public string Adres { get; set; }
        public string EMail { get; set; }
        public string KisiNo { get; set; }
    }
    public class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriTuru { get; set; }
    }
    public class KategoriTuru
    {
        public string Kategorituru { get; set; }
        public string KonserAdi { get; set; }
        public string TiyatroAdi { get; set; }
        public string SinemaAdi { get; set; }
        public string BalerinAdi { get; set; }
    }
    public class Musteri
    {
        public int KisiNo { get; set; }
        public int KimlikNo { get; set; }
        public int SiparisNo { get; set; }
    }
    public class OdemeTuru
    {
        public string Odemeturu { get; set; }
        public string KrediKarti { get; set; }
        public string TaksitliOdeme { get; set; }
        public string KuponOdeme { get; set; }
        public string ECuzdan { get; set; }
    }
    public class Siparis
    {
        public int SiparisNo { get; set; }
        public DateTime SiparişTarihi { get; set; }
        public int ToplamTutar { get; set; }
        public int FaturaNo { get; set; }
        public int SiparisMiktari { get; set; }
        public int BiletID { get; set; }
    }
}