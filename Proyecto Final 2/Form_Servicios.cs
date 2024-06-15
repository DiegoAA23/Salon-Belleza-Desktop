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
    public partial class Form_Servicios : Form
    {
        public Form_Servicios()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        SqlCommand cmd;
        int i;

        private void Form_Servicios_Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Servicios");
            connect.cargarDatos(dgvConsulta, "Servicios");
            connect.cargarDatos(dgvActualizar, "Servicios");
            connect.cargarDatos(dgvEliminar, "Servicios");
        }

        private void btnConfirmar_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = Convert.ToDouble(txtPrecio_Agregar.Text);
                if (txtNombre_Agregar.Text == String.Empty || txtPrecio_Agregar.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Insert Into Servicios(NombreServicio, PrecioServicio) Values('" + txtNombre_Agregar.Text + "', '" + precio + "')", connect.sc);
                    cmd.ExecuteNonQuery();
                    connect.cargarDatos(dgvAgregar, "Servicios");

                    txtNombre_Agregar.Text = " ";
                    txtPrecio_Agregar.Text = " ";

                    txtNombre_Agregar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtNombre_Agregar.Clear();
                txtPrecio_Agregar.Clear();
            }

        }

        private void rbCodigo_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo_Consulta.Checked)
            {
                txtCodigo_Consulta.ReadOnly = false;
                txtNombre_Consulta.ReadOnly = true;
                txtNombre_Consulta.Clear();

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
                txtNombre_Consulta.ReadOnly = false;
                txtCodigo_Consulta.ReadOnly = true;
                txtCodigo_Consulta.Clear();

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

        private void btnConfirmar_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre_Actualizar.Text == String.Empty || txtPrecio_Actualizar.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string actualizar = "UPDATE Servicios " +
                   "SET NombreServicio=@ns, PrecioServicio=@ps " +
                   "WHERE CodigoServicio=@cs;";

                    using (SqlCommand command = new SqlCommand(actualizar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@ns", txtNombre_Actualizar.Text);
                        command.Parameters.AddWithValue("@cs", txtCodigo_Actualizar.Text);
                        command.Parameters.AddWithValue("@ps", txtPrecio_Actualizar.Text);

                        command.ExecuteNonQuery();
                    }

                    connect.cargarDatos(dgvActualizar, "Servicios");

                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            ctr.Text = " ";
                        }
                    }

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
                txtPrecio_Actualizar.Clear();
            }

        }

        private void dgvActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            txtCodigo_Actualizar.Text = dgvActualizar.CurrentRow.Cells[0].Value.ToString();
            txtCodigo_Actualizar.Enabled = false;
            txtNombre_Actualizar.Text = dgvActualizar.CurrentRow.Cells[1].Value.ToString();
            txtPrecio_Actualizar.Text = dgvActualizar.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnConfirmar_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo_Eliminar.Text != String.Empty)
                {

                    string borrar = "DELETE FROM Servicios WHERE CodigoServicio=@cs;";

                    using (SqlCommand command = new SqlCommand(borrar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@cs", txtCodigo_Eliminar.Text);
                        command.ExecuteNonQuery();
                        connect.cargarDatos(dgvEliminar, "Servicios");
                    }
                }

                connect.cargarDatos(dgvEliminar, "Servicios");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la columna" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                txtCodigo_Eliminar.Clear();
            }

        }

        private void btnRegresar_Agregar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
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

        private void tbcServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Cerrar();
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Servicios");
            connect.cargarDatos(dgvConsulta, "Servicios");
            connect.cargarDatos(dgvActualizar, "Servicios");
            connect.cargarDatos(dgvEliminar, "Servicios");
        }
    }
}
