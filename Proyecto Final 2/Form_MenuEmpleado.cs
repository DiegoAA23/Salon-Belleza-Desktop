using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public partial class Form_MenuEmpleado : Form
    {
        public Form_MenuEmpleado()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFaturacion_Click(object sender, EventArgs e)
        {
            FormCobro cobro = new FormCobro();
            cobro.ShowDialog();
        }

        private void btnClietes_Click(object sender, EventArgs e)
        {
            Form_ClientesEmpleados cliente = new Form_ClientesEmpleados();
            cliente.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Form_ServiciosEmpleado servicio = new Form_ServiciosEmpleado();
            servicio.ShowDialog();
        }
    }
}
