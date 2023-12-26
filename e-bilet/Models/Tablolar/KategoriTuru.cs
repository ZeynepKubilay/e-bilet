using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models.tablolar
{
    public class KategoriTuru : DbContext
    {
        public string Kategorituru { get; set; }
        public string KonserAdi { get; set; }
        public string TiyatroAdi { get; set; }
        public string SinemaAdi { get; set; }
        public string BalerinAdi { get; set; }
        
    }
}