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
    public partial class Form_ClientesEmpleados : Form
    {
        public Form_ClientesEmpleados()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        int i;
        SqlCommand cmd;
        clsClientes cliente = new clsClientes();
        private void Form_ClientesEmpleados_Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Clientes");
            connect.cargarDatos(dgvConsulta, "Clientes");
        }

        private void btnConfirmar_Agregar_Click(object sender, EventArgs e)
        {
            string fecha = dtpFechaNacimiento_Agregar.Value.ToString("yyyy/MM/dd");

            cliente.Nombre = txtNombre_Agregar.Text;
            cliente.Apellido = txtApellido_Agregar.Text;
            cliente.Direccion = txtDireccion_Agregar.Text;
            cliente.FechaNac = fecha;
            cliente.Telefono = txtTelefono_Agregar.Text;

            try
            {

                if (txtNombre_Agregar.Text == String.Empty || txtApellido_Agregar.Text == String.Empty || txtDireccion_Agregar.Text == String.Empty || dtpFechaNacimiento_Agregar == null || txtTelefono_Agregar.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cliente.AgregarCliente();
                    connect.cargarDatos(dgvAgregar, "Clientes");

                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            ctr.Text = " ";
                        }
                    }

                    dtpFechaNacimiento_Agregar = null;
                    txtNombre_Agregar.Focus();
                    connect.cargarDatos(dgvAgregar, "Clientes");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void rbCodigo_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo_Consulta.Checked)
            {
                txtCodigo_Consulta.ReadOnly = false;
                txtNombre_Consulta.ReadOnly = true;
                txtNombre_Consulta.Clear();
                connect.cargarDatos(dgvConsulta, "Clientes");
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
                txtNombre_Consulta.ReadOnly = false;
                txtCodigo_Consulta.ReadOnly = true;
                txtCodigo_Consulta.Clear();
                connect.cargarDatos(dgvConsulta, "Clientes");
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

                    string consulta = "Select * from Clientes where CodigoCliente = '" + txtCodigo_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;

                }
                else if (txtNombre_Consulta.Text != String.Empty)
                {
                    string consulta = "Select * from Clientes where NombreCliente = '" + txtNombre_Consulta.Text + "'";
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
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNombre_Consulta.Clear();
                txtCodigo_Consulta.Clear();
            }
        }

        private void btnRegresar_Agregar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void btnSalir_Agregar_Click(object sender, EventArgs e)
        {

            connect.Cerrar();
            Application.Exit();
        }

        private void btnSalir_Consulta_Click(object sender, EventArgs e)
        {

            connect.Cerrar();
            Application.Exit();
        }

        private void btnRegresar_Consulta_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void tbcClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Cerrar();
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Clientes");
            connect.cargarDatos(dgvConsulta, "Clientes");
        }

        private void dgvAgregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
