﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;



namespace e_bilet.Models 
{
    public class Admin : DbContext
    {
        public int KisiNo { get; set; }
        public int KimlikNo  { get; set; }
    }

    
}