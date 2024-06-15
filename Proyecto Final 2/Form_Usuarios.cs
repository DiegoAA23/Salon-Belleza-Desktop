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
    public partial class Form_Usuarios : Form
    {
        public Form_Usuarios()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        int i;
        SqlCommand cmd;

        private void Form_Usuarios_Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Usuarios");
            connect.cargarDatos(dgvConsulta, "Usuarios");
            connect.cargarDatos(dgvActualizar, "Usuarios");
            connect.cargarDatos(dgvEliminar, "Usuarios");
        }

        private void btnConfirmar_Agregar_Click(object sender, EventArgs e)
        {
            bool estadousuario;

            try
            {

                if (cboxEstado_Agregar.Text == "Activo")
                {
                    estadousuario = true;
                }
                else
                {
                    estadousuario = false;
                }

                if (txtCodigoEmpleado_Agregar.Text == String.Empty || txtNombre_Agregar.Text == String.Empty || txtContraseña_Agregar.Text == String.Empty || txtConfirmContraseña_Agregar.Text == String.Empty || cboxEstado_Agregar == null || txtCodigoEmpleado_Agregar.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (txtContraseña_Agregar.Text != txtConfirmContraseña_Agregar.Text)
                {
                    MessageBox.Show("El dato de Contraseña y Confirmar Contraseña no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Insert into Usuarios (CodigoUsuario,NombreUsuario,PasswordUsuario,CodEstado,CodEmpleado) Values('" + txtCodigo_Agregar.Text + "', '" + txtNombre_Agregar.Text + "', '" + txtContraseña_Agregar.Text + "', '" + estadousuario + "', '" + txtCodigoEmpleado_Agregar.Text + "' )", connect.sc);
                    cmd.ExecuteNonQuery();
                    connect.cargarDatos(dgvAgregar, "Usuarios");

                    foreach (Control ctr in this.Controls)
                    {
                        if (ctr is TextBox)
                        {
                            ctr.Text = " ";
                        }
                    }

                    txtNombre_Agregar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbCodigo_Consultar_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCodigo_Consultar.Checked)
            {
                txtCodigo_Consulta.ReadOnly = false;
                txtNombre_Consulta.ReadOnly = true;
                txtNombre_Consulta.Clear();

                connect.cargarDatos(dgvConsulta, "Usuarios");
            }
            else
            {
                txtCodigo_Consulta.ReadOnly = true;
            }
        }

        private void rbNombre_Consulta_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbNombre_Consulta.Checked)
            {
                txtNombre_Consulta.ReadOnly = false;
                txtCodigo_Consulta.ReadOnly = true;
                txtCodigo_Consulta.Clear();

                connect.cargarDatos(dgvConsulta, "Usuarios");
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

                    string consulta = "Select * from Usuarios where CodigoUsuario = '" + txtCodigo_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;

                }
                else if (txtNombre_Consulta.Text != String.Empty)
                {
                    string consulta = "Select * from Usuarios where NombreUsuario = '" + txtNombre_Consulta.Text + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvConsulta.DataSource = tabla;
                }
            }
            catch
            {
                MessageBox.Show("No es posible consultar los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Actualizar_Click(object sender, EventArgs e)
        {
            bool estadousuario;
            try
            {
                if (cboxEstado_Actualizar.Text == "Activo")
                {
                    estadousuario = true;
                }
                else
                {
                    estadousuario = false;
                }


                if (txtCodigoEmpleado_Actualizar.Text == String.Empty || txtNombre_Actualizar.Text == String.Empty || txtContraseña_Actualizar.Text == String.Empty || txtConfirmarContraseña_Actualizar.Text == String.Empty || cboxEstado_Actualizar == null)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtContraseña_Actualizar.Text != txtConfirmarContraseña_Actualizar.Text)
                {
                    MessageBox.Show("El dato de Contraseña y Confirmar Contraseña no coinciden", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string actualizar = "UPDATE Usuarios " +
                    "SET NombreUsuario=@nu,PasswordUsuario=@pu,CodEstado=@ceu,CodEmpleado=@ce" +
                    " WHERE CodigoUsuario=@cu;";

                    using (SqlCommand command = new SqlCommand(actualizar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@nu", txtNombre_Actualizar.Text);
                        command.Parameters.AddWithValue("@pu", txtContraseña_Actualizar.Text);
                        command.Parameters.AddWithValue("@ceu", estadousuario);
                        command.Parameters.AddWithValue("@ce", txtCodigoEmpleado_Actualizar.Text);
                        command.Parameters.AddWithValue("@cu", txtCodigoUsuario_Actualizar.Text);

                        command.ExecuteNonQuery();
                    }

                    connect.cargarDatos(dgvActualizar, "Usuarios");

                    txtNombre_Actualizar.Clear();
                    txtCodigoEmpleado_Actualizar.Clear();
                    txtContraseña_Actualizar.Clear();
                    txtConfirmarContraseña_Actualizar.Clear();
                    txtCodigoUsuario_Actualizar.Clear();
                    cboxEstado_Actualizar.Text = null;

                    txtNombre_Actualizar.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dgvActualizar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            txtCodigoUsuario_Actualizar.Text = dgvActualizar.CurrentRow.Cells[0].Value.ToString();
            txtCodigoUsuario_Actualizar.Enabled = false;
            txtNombre_Actualizar.Text = dgvActualizar.CurrentRow.Cells[1].Value.ToString();
            txtContraseña_Actualizar.Text = dgvActualizar.CurrentRow.Cells[2].Value.ToString();

            if (dgvActualizar.CurrentRow.Cells[3].Value.ToString() == "False")
            {
                cboxEstado_Actualizar.Text = "Inactivo";
            }
            else
            {
                cboxEstado_Actualizar.Text = "Activo";
            }

            txtCodigoEmpleado_Actualizar.Text = dgvActualizar.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnConfirmar_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigo_Eliminar.Text != String.Empty)
                {

                    string borrar = "DELETE FROM Usuarios WHERE CodigoUsuario=@cu;";

                    using (SqlCommand command = new SqlCommand(borrar, connect.sc))
                    {
                        command.Parameters.AddWithValue("@cu", txtCodigo_Eliminar.Text);
                        command.ExecuteNonQuery();
                        connect.cargarDatos(dgvEliminar, "Usuarios");
                    }


                }

                connect.cargarDatos(dgvActualizar, "Usuarios");

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

        private void btnSalir_Eliminar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            Application.Exit();
        }

        private void btnSalir_Actualizar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            Application.Exit();
        }

        private void btnSalir_Consulta_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            Application.Exit();
        }

        private void btnSalir_Agregar_Click(object sender, EventArgs e)
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

        private void tbcUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            connect.Cerrar();
            connect.abrir();
            connect.cargarDatos(dgvAgregar, "Usuarios");
            connect.cargarDatos(dgvConsulta, "Usuarios");
            connect.cargarDatos(dgvActualizar, "Usuarios");
            connect.cargarDatos(dgvEliminar, "Usuarios");
        }
    }
}
