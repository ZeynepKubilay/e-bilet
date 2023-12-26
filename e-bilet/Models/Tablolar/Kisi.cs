using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models.tablolar
{
    public class Kisi :DbContext
    {
        [Key] 
        public int KisiNo { get; set; }
        public int KisiAd {  get; set; }
        public int KisiSoyad { get; set; }
        public int KisiTuru { get; set; }
    }
}