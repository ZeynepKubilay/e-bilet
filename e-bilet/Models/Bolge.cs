using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models
{
    public class Bolge 
    {
        public int BolgeNo { get; set; }
        public string Il {  get; set; }
        public string Ilce { get; set; }
        public string Mahalle { get; set; }
    }
   
}