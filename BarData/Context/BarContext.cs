using BarData.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarData.Context
{
    public class BarContext : DbContext
    { 
        public DbSet<Cerveja> Cerveja { get; set; }

        public DbSet<Refrigerante> Refrigerante { get; set; }

        public BarContext() : base("ConnectionBar")
        {

        }
    }
}