using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIClientes
{
    public partial class Maestro : Form
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void porCodigoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaporCodigo consultaCodigo = new ConsultaporCodigo();
            consultaCodigo.Show();
        }

        private void nombreAcreedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PorAcreedores consultaAcreedores = new PorAcreedores(); 
            consultaAcreedores.Show();
        }

        private void ingresarCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarCredito ingresarCredito = new IngresarCredito();
            ingresarCredito.Show();
        }

        private void retirarCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RetirarCredito retirar = new RetirarCredito();
            retirar.Show();
        }

        private void cambiarDatosCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CambiarDatosCreditos cambiar = new CambiarDatosCreditos();
            cambiar.Show();
        }

        private void realizarPagoDeCuotaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PagoCuota Pago = new PagoCuota();
            Pago.Show();
        }
    }
}
