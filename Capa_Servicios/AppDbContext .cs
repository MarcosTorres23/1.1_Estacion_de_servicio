using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; 


namespace Capa_Servicios
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("name=AppDbContext") { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Rol> Roles { get; set; }
    }
}
