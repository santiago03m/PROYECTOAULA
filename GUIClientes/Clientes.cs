using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIClientes
{
    internal class Clientes
    {
        private int id_Cliente;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;
        private string fecha_registro;

        public Clientes(int id_Cliente, string nombre, string apellido, string direccion, string telefono, string fecha_registro)
        {
            this.Id_Cliente = id_Cliente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Fecha_registro = fecha_registro;
        }

        public int Id_Cliente { get => id_Cliente; set => id_Cliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Fecha_registro { get => fecha_registro; set => fecha_registro = value; }
    }
}
