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
    public partial class Form_MenuAdministrador : Form
    {
        public Form_MenuAdministrador()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Form_Empleados empleado = new Form_Empleados();
            empleado.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Form_Cliente_ cliente = new Form_Cliente_();
            cliente.ShowDialog();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form_Usuarios usuario = new Form_Usuarios();
            usuario.ShowDialog();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Form_Servicios servicio = new Form_Servicios();
            servicio.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
            FormCobro cobro = new FormCobro();
            cobro.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
