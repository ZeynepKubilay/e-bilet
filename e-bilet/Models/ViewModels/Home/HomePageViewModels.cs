using e_bilet.Models.tablolar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_bilet.Models; // burası bu şekilde mi olacak sor 6. hafta sayfa 21.


namespace e_bilet.Models.ViewModels.Home
{
    public class HomePageViewModels
    { 
        public List<Admin> Admins { get; set; }
        public List<Bilet> Bilets {  get; set; }
        public List<Bolge> Bolges { get; set; }
        public List<Etkinlik> Etkinliks { get; set; }
        public List<Fatura> Faturas { get; set; }
        public List<IletisimBilgileri> IletisimBilgileris { get; set; }
        public List<Kategori> Kategoris { get; set; }
        public List<KategoriTuru> KategoriTurus { get; set; }
        public List<Kisi> Kisis { get; set; }
        public List<Musteri> Musteris { get; set; }
        public List<OdemeTuru> OdemeTurus { get; set; }
        public List<Siparis> Sipariss { get; set; }
    }
}