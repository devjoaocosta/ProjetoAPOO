using Projeto_Apoo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Projeto_Apoo.Context
{
    public class EFContext : DbContext
    {
        public EFContext() : base ("ProjetoApoo") { }
        public DbSet<Item> Items { get; set; }
    }
}