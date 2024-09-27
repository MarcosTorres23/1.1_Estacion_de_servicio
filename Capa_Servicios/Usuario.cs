using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Servicios
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public int IdRol { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public string Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
