using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proyecto_Final_2
{
    public partial class Form_ServiciosEmpleado : Form
    {
        public Form_ServiciosEmpleado()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();


        private void rbCodigo_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo_Consulta.Checked)
            {
                txtNombre_Consulta.Clear();
                txtCodigo_Consulta.ReadOnly = false;
                txtNombre_Consulta.ReadOnly = true;

                connect.cargarDatos(dgvConsulta, "Servicios");
            }
            else
            {
                txtCodigo_Consulta.ReadOnly = true;
            }
        }

        private void rbNombre_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre_Consulta.Checked)
            {
                txtCodigo_Consulta.Clear();
                txtNombre_Consulta.ReadOnly = false;
                txtCodigo_Consulta.ReadOnly = true;

                connect.cargarDatos(dgvConsulta, "Servicios");
            }
            else
            {
                txtNombre_Consulta.ReadOnly = true;
            }
        }

        private void btnConfirmar_Consulta_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo_Consulta.Text != String.Empty)
                {

                    string consulta = "Select * from Servicios where CodigoServicio = '" + txtCodigo_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;

                }
                else if (txtNombre_Consulta.Text != String.Empty)
                {

                    string consulta = "Select * from Servicios where NombreServicio = '" + txtNombre_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;
                }
                else
                {
                    MessageBox.Show("No es posible consultar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en la tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNombre_Consulta.Clear();
                txtCodigo_Consulta.Clear();
            }
        }

        private void Form_ServiciosEmpleado_Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatos(dgvConsulta, "Servicios");
        }

        private void btnRegresar_Consulta_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void btnSalir_Consulta_Click(object sender, EventArgs e)
        {

            connect.Cerrar();
            Application.Exit();
        }
    }
}
