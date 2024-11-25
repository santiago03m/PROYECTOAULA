using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Cliente
    {
        public int ID_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public DateTime? Fecha_Registro { get; set; }
    }
}
