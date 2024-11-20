using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Rol { get; set; }
        public DateTime Ultimo_Acceso { get; set; } 
        public string Estado_Cuenta { get; set; }
    }

}
