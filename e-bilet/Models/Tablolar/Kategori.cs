using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models.tablolar
{
    public class Kategori :DbContext
    {
       public int KategoriID {  get; set; }
        public string KategoriTuru { get; set;}
    }
}