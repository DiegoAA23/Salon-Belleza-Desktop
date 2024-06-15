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
    public partial class Form_Empleados : Form
    {
        public Form_Empleados()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        SqlCommand cmd;

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form_Empleados_Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Empleados");
            connect.cargarDatos(dgvConsulta, "Empleados");
            connect.cargarDatos(dgvActualizar, "Empleados");
            connect.cargarDatos(dgvEliminar, "Empleados");
            connect.Cerrar();
            connect.abrir();

            try
            {
                cmd = new SqlCommand("Select * from Puestos", connect.sc);

                SqlDataReader registro = cmd.ExecuteReader();
                comboBox1.DisplayMember = "Text";
                comboBox2.DisplayMember = "Text";

                while (registro.Read())
                {
                    comboBox1.Items.Add(new { Text = registro["DescripcionPuesto"], Value = registro["CodigoPuesto"].ToString() });
                    comboBox2.Items.Add(new { Text = registro["DescripcionPuesto"], Value = registro["CodigoPuesto"].ToString() });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar dato en el ComboBox" + ex, "ERROR");
            }
            finally 
            {
                connect.Cerrar();
                connect.abrir();
                
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {

                Console.WriteLine((comboBox1.SelectedItem as dynamic).Value);

                string fecha = dtpFechaNacimiento_Agregar.Value.ToString("yyyy/MM/dd");

                if (txtNombre_Agregar.Text == String.Empty || txtCorreo_Agregar.Text == String.Empty || comboBox1 == null || txtApellido_Agregar.Text == String.Empty || txtDireccion_Agregar.Text == String.Empty || dtpFechaNacimiento_Agregar == null || txtTelefono_Agregar.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    cmd = new SqlCommand("Insert into Empleados (NombreEmpleado, ApellidoEmpleado, DireccionEmpleado, FechaNacEmpleado, TelefonoEmpleado, CorreoEmpleado, CodPuesto) Values('" + txtNombre_Agregar.Text + "', '" + txtApellido_Agregar.Text + "', '" + txtDireccion_Agregar.Text + "', '" + fecha + "', '" + txtTelefono_Agregar.Text + "','" + txtCorreo_Agregar.Text + "','" + (comboBox1.SelectedItem as dynamic).Value + "')", connect.sc);
                    cmd.ExecuteNonQuery();
                    connect.cargarDatos(dgvAgregar, "Empleados");

                    txtNombre_Agregar.Clear();
                    txtApellido_Agregar.Clear();
                    txtDireccion_Agregar.Clear();
                    comboBox1 = null;
                    txtTelefono_Agregar.Clear();
                    txtCorreo_Agregar.Clear();
                    dtpFechaNacimiento_Agregar = null;
                    txtNombre_Agregar.Focus();
                    connect.cargarDatos(dgvAgregar, "Empleados");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos en el ComboBox" + ex, "ERROR");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            Application.Exit();
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

        private void rbCodigo_Consulta_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo_Consulta.Checked)
            {
                txtNombre_Consulta.Clear();
                txtCodigo_Consulta.ReadOnly = false;
                txtNombre_Consulta.ReadOnly = true;

                connect.cargarDatos(dgvConsulta, "Empleados");
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
                connect.cargarDatos(dgvConsulta, "Empleados");
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

                    string consulta = "Select * from Empleados where CodigoEmpleado = '" + txtCodigo_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;

                }
                else if (txtNombre_Consulta.Text != String.Empty)
                {
                    string consulta = "Select * from Empleados where NombreEmpleado = '" + txtNombre_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    string actualizar = "UPDATE Empleados " +
                    "SET NombreEmpleado=@ne, ApellidoEmpleado=@ae, DireccionEmpleado=@de, FechaNacEmpleado=@fne, TelefonoEmpleado=@te, CorreoEmpleado=@coe " +
                    " WHERE CodigoEmpleado=@ce;";

                    using (SqlCommand command = new SqlCommand(actualizar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@ne", txtNombre_Actualizar.Text);
                        command.Parameters.AddWithValue("@ae", txtApellido_Actualizar.Text);
                        command.Parameters.AddWithValue("@de", txtDireccion_Actualizar.Text);
                        command.Parameters.AddWithValue("@fne", fecha);
                        command.Parameters.AddWithValue("@te", txtTelefono_Actualizar.Text);
                        command.Parameters.AddWithValue("@ce", txtCodigo_Actualizar.Text);
                        command.Parameters.AddWithValue("@coe", txtCorreo_Actualizar.Text);

                        command.ExecuteNonQuery();

                    }

                    connect.cargarDatos(dgvActualizar, "Empleados");

                    txtNombre_Actualizar.Clear();
                    txtApellido_Actualizar.Clear();
                    txtDireccion_Actualizar.Clear();
                    txtTelefono_Actualizar.Clear();
                    txtCodigo_Actualizar.Clear();
                    txtCorreo_Actualizar.Clear();

                    

                    dtpFechaNacimiento_Actualizar = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvActualizar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConfirmar_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo_Eliminar.Text != String.Empty)
                {

                    string borrar = "DELETE FROM Empleados WHERE CodigoEmpleado=@ce;";

                    using (SqlCommand command = new SqlCommand(borrar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@ce", txtCodigo_Eliminar.Text);
                        command.ExecuteNonQuery();
                        connect.cargarDatos(dgvEliminar, "Empleados");
                    }
                }

                connect.cargarDatos(dgvEliminar, "Empleados");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la columna" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            txtCodigo_Eliminar.Text = dgvEliminar.CurrentRow.Cells[0].Value.ToString();
            txtCodigo_Eliminar.Enabled = false;
        }

        private void dgvEliminar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbcEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Cerrar();
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Empleados");
            connect.cargarDatos(dgvConsulta, "Empleados");
            connect.cargarDatos(dgvActualizar, "Empleados");
            connect.cargarDatos(dgvEliminar, "Empleados");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}
