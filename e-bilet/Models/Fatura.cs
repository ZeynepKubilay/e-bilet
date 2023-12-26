using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models
{
    public class Fatura :DbContext
    {
        public int FaturaNo { get; set; }
        public DateTime FaturaTarihi { get; set; }
        public string OdemeTuru { get; set; }
    }
}