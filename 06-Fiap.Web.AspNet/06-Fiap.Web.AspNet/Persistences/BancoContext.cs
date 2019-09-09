﻿using _06_Fiap.Web.AspNet.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_Fiap.Web.AspNet.Persistences
{
    public class BancoContext : DbContext
    {
        public DbSet<Condominio> Condominios { get; set; }

        public BancoContext(DbContextOptions o) : base(o)
        {

        }
    }
}
