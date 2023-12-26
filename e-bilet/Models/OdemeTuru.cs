using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models
{
    public class OdemeTuru : DbContext
    {
        public string Odemeturu { get; set; }
        public string KrediKarti { get; set; }
        public string TaksitliOdeme { get; set; }
        public string KuponOdeme { get; set; }
        public string ECuzdan { get; set; }
    }
}