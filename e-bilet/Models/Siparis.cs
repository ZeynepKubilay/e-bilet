using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models
{
    public class Siparis : DbContext
    {
        public int SiparisNo {  get; set; }
        public DateTime SiparişTarihi { get; set; }
        public int ToplamTutar {  get; set; }
        public int FaturaNo { get; set; }
        public int SiparisMiktari { get; set; }
        public int BiletID { get; set; }
    }
}