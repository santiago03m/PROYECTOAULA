using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIClientes
{
    public class Creditos
    {
        public int ID_Credito { get; set; }
        public int ID_Cliente { get; set; }
        public decimal Monto_Total { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Vencimiento { get; set; }
        public decimal Tasa_Interes { get; set; }
        public string Estado { get; set; }
        public int Cuotas { get; set; }
    }
}

