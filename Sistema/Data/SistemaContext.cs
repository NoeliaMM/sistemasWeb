using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Sistema.Models
{
    public class SistemaContext : DbContext
    {
        public SistemaContext (DbContextOptions<SistemaContext> options)
            : base(options)
        {
        }

        public DbSet<Categoria> Categoria { get; set; }
    }
}
