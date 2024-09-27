using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Servicios
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Celular { get; set; }
        public string Email { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
