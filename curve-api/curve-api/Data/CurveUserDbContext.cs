﻿using curve_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curve_api.Data
{
    public class CurveUserDBContext : DbContext
    {
        public CurveUserDBContext(DbContextOptions<CurveUserDBContext> options) : base(options)
        {
        }

        // Set DB Tables
        public DbSet<User> Users { get; set; }
    }
}
