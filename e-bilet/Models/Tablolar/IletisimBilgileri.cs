using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace e_bilet.Models.tablolar
{
    public class IletisimBilgileri : DbContext
    {
        [Key]
        public int No { get; set; }
        public int TelefonNumarasi { get; set; }
        public string Adres { get; set; }
        public string EMail { get; set; }
        public string KisiNo { get; set; }


    }
}