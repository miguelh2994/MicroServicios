using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TiendaServicios.Api.Libro2.Persistencia
{
    public class ContextoLibreria : DbContext
    {
        public ContextoLibreria() { }
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options) { }

        public virtual DbSet<LibreriaMaterial> LibreriaMaterial { get; set; }
    }
}
