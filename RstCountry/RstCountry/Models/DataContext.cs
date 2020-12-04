﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RstCountry.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<RstCountry.Models.Country> Countries { get; set; }
    }
}