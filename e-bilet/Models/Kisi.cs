using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using e_bilet.Models.Managers;

namespace e_bilet.Models
{
    public class Kisi :MyDbContext
    {
        [Key] 
        public int KisiNo { get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        public string KisiTuru { get; set; }
        public string Sifre { get; set; }
    }
}