using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models.tablolar
{
    public class Bilet
    {
        public int BiletID {  get; set; }
        public int EtkinlikID { get; set; }
        public int Ucret { get; set; }
    }
    
}