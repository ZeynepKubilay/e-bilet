using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models
{
    public class Etkinlik :DbContext
    {
        public int EtkinlikID { get; set; }
        public string EtkinlikAdı { get; set; }
        public int KategoriID {  get; set; }
        public int BolgeNo {  get; set; }
        public DateTime Saat {  get; set; }
        public DateTime Tarih {  get; set; }

    }
}