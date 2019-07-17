using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PaineisSolares.Models
{
    public class PaineisSolaresContext : DbContext
    {
        public PaineisSolaresContext (DbContextOptions<PaineisSolaresContext> options)
            : base(options)
        {
        }

        public DbSet<Ambiente> Ambiente { get; set; }
        public DbSet<Equipamento> Equipamento { get; set; }
    }
}
