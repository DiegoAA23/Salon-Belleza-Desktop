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
    public partial class Form_Cliente_ : Form
    {
        public Form_Cliente_()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        SqlCommand cmd;
        clsClientes cliente = new clsClientes();
        private void Form_Cliente__Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Clientes");
            connect.cargarDatos(dgvConsulta, "Clientes");
            connect.cargarDatos(dgvActualizar, "Clientes");
            connect.cargarDatos(dgvEliminar, "Clientes");
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
                    connect.Cerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNombre_Agregar.Clear();
                txtApellido_Agregar.Clear();
                txtDireccion_Agregar.Clear();
                dtpFechaNacimiento_Agregar = null;
                txtTelefono_Agregar.Clear();
                txtNombre_Agregar.Focus();
                connect.cargarDatos(dgvAgregar, "Clientes");
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
                    connect.Cerrar();

                }
                else if (txtNombre_Consulta.Text != String.Empty)
                {
                    cliente.ClienteConsulta(txtNombre_Consulta.Text);
                    SqlCommand comando = new SqlCommand(cliente.Consultan, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;
                    connect.Cerrar();

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

        private void btnConfirmar_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string fecha = dtpFechaNacimiento_Actualizar.Value.ToString("yyyy/MM/dd");

                if (txtNombre_Actualizar.Text == String.Empty || txtApellido_Actualizar.Text == String.Empty || txtDireccion_Actualizar.Text == String.Empty || dtpFechaNacimiento_Actualizar == null || txtTelefono_Actualizar.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    string actualizar = "UPDATE Clientes " +
                    "SET NombreCliente=@nc, ApellidoCliente=@ac, DireccionCliente=@dc, FechaNacCliente=@fnc, TelefonoCliente=@tc " +
                    " WHERE CodigoCliente=@cc;";

                    using (SqlCommand command = new SqlCommand(actualizar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@nc", txtNombre_Actualizar.Text);
                        command.Parameters.AddWithValue("@ac", txtApellido_Actualizar.Text);
                        command.Parameters.AddWithValue("@dc", txtDireccion_Actualizar.Text);
                        command.Parameters.AddWithValue("@fnc", fecha);
                        command.Parameters.AddWithValue("@tc", txtTelefono_Actualizar.Text);
                        command.Parameters.AddWithValue("@cc", txtCodigo_Actualizar.Text);

                        command.ExecuteNonQuery();

                    }

                    connect.cargarDatos(dgvActualizar, "Clientes");


                    txtNombre_Actualizar.Clear();
                    txtApellido_Actualizar.Clear();
                    txtDireccion_Actualizar.Clear();
                    txtTelefono_Actualizar.Clear();
                    txtCodigo_Actualizar.Clear();

                    dtpFechaNacimiento_Actualizar = null;
                    txtNombre_Actualizar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                txtCodigo_Actualizar.Clear();
                txtNombre_Actualizar.Clear();
                txtApellido_Actualizar.Clear();
                txtDireccion_Actualizar.Clear();
                dtpFechaNacimiento_Actualizar = null;
                txtTelefono_Actualizar.Clear();
                txtNombre_Actualizar.Focus();
                connect.cargarDatos(dgvActualizar, "Clientes");

            }

        }

        private void dgvActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;
            txtCodigo_Actualizar.Text = dgvActualizar.CurrentRow.Cells[0].Value.ToString();
            txtCodigo_Actualizar.Enabled = false;
            txtNombre_Actualizar.Text = dgvActualizar.CurrentRow.Cells[1].Value.ToString();
            txtApellido_Actualizar.Text = dgvActualizar.CurrentRow.Cells[2].Value.ToString();
            txtDireccion_Actualizar.Text = dgvActualizar.CurrentRow.Cells[3].Value.ToString();
            txtTelefono_Actualizar.Text = dgvActualizar.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnConfirmar_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo_Eliminar.Text != String.Empty)
                {
                    string borrar = "DELETE FROM Clientes WHERE CodigoCliente=@cc;";

                    using (SqlCommand command = new SqlCommand(borrar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@cc", txtCodigo_Eliminar.Text);
                        command.ExecuteNonQuery();
                        connect.cargarDatos(dgvEliminar, "Clientes");
                    }
                }

                connect.cargarDatos(dgvActualizar, "Clientes");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la columna" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Agregar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void tpConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Consulta_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void btnRegresar_Actualizar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void btnRegresar_Eliminar_Click(object sender, EventArgs e)
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

        private void btnSalir_Actualizar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            Application.Exit();
        }

        private void btnSalir_Eliminar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            Application.Exit();
        }

        private void dgvEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            txtCodigo_Eliminar.Text = dgvEliminar.CurrentRow.Cells[0].Value.ToString();
            txtCodigo_Eliminar.Enabled = false;
        }

        private void tbcClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Cerrar();
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Clientes");
            connect.cargarDatos(dgvConsulta, "Clientes");
            connect.cargarDatos(dgvActualizar, "Clientes");
            connect.cargarDatos(dgvEliminar, "Clientes");
        }

        private void txtNombre_Agregar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
