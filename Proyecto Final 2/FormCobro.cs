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
    public partial class FormCobro : Form
    {
        public FormCobro()
        {
            InitializeComponent();
        }
        clsConexion connect = new clsConexion();
        SqlCommand cmd;

        double precio = 0, historico = 0;

        private void cboxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                cmd = new SqlCommand("Select * from Servicios", connect.sc);

                string consulta = "SELECT * from Servicios WHERE CodigoServicio = '" + (cboxServicio.SelectedItem as dynamic).Value + "'";
                SqlCommand comando = new SqlCommand(consulta, connect.sc);
                SqlDataReader registro = comando.ExecuteReader();
                while (registro.Read())
                {
                    txtCodigo.Text = (cboxServicio.SelectedItem as dynamic).Value;
                    txtNombre.Text = Convert.ToString((registro["NombreServicio"]));
                    txtPrecio.Text = Convert.ToString((registro["PrecioServicio"]));
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                connect.Cerrar();
                connect.abrir();
            }
        }

        private void FormCobro_Load(object sender, EventArgs e)
        {
            connect.abrir();

            try
            {
                cmd = new SqlCommand("Select * from Servicios", connect.sc);

                SqlDataReader registro = cmd.ExecuteReader();
                cboxServicio.DisplayMember = "Text";

                while (registro.Read())
                {
                    cboxServicio.Items.Add(new { Text = registro["NombreServicio"], Value = registro["CodigoServicio"].ToString() });
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar dato en el ComboBox", "ERROR");
            }
            finally
            {
                connect.Cerrar();
                connect.abrir();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int servicio = 0;

            try
            {

                cmd = new SqlCommand("Select * from Servicios", connect.sc);

                string consulta = "SELECT * from Servicios WHERE CodigoServicio = '" + (cboxServicio.SelectedItem as dynamic).Value + "'";
                SqlCommand comando = new SqlCommand(consulta, connect.sc);
                SqlDataReader serv = comando.ExecuteReader();
                while (serv.Read())
                {
                    precio = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble((serv["PrecioServicio"]));
                    historico = historico + precio;
                    lblTotal.Text = Convert.ToString(historico);

                }

                connect.Cerrar();
                connect.abrir();

                if (cboxServicio == null || txtCantidad.Text == String.Empty)
                {
                    MessageBox.Show("No se puede ingresar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    cmd = new SqlCommand("Insert into Detalle (CodigoFactura, CodServicio, CantidadServicio, PrecioHistorico) Values('" + Convert.ToInt32(txtCodFactura.Text) + "', '" + (cboxServicio.SelectedItem as dynamic).Value + "', '" + Convert.ToInt32(txtCantidad.Text) + "', '" + precio + "')", connect.sc);
                    cmd.ExecuteNonQuery();
                    connect.Cerrar();
                    connect.abrir();

                    string select = "Select * from Detalle Where CodigoFactura = '" + Convert.ToInt16(txtCodFactura.Text) + "'";
                    SqlCommand reabrir = new SqlCommand(select, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(reabrir);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dataGridView_OrdenVenta.DataSource = tabla;

                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtPrecio.Clear();
                    txtCantidad.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtCodFactura_TextChanged(object sender, EventArgs e)
        {
            historico = 0;
        }

        private void txtCodFactura_Leave(object sender, EventArgs e)
        {
            try
            {
                string consulta = "Select * from Detalle Where CodigoFactura = '" + Convert.ToInt16(txtCodFactura.Text) + "'";
                SqlCommand comando = new SqlCommand(consulta, connect.sc);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView_OrdenVenta.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                string borrar = "DELETE FROM Detalle WHERE CodigoFactura=@cf AND CodServicio=@cs AND CantidadServicio=@cd;";

                using (SqlCommand command = new SqlCommand(borrar, connect.sc))
                {
                    command.Parameters.AddWithValue("@cf", txtCodFactura.Text);
                    command.Parameters.AddWithValue("@cs", txtCodigo.Text);
                    command.Parameters.AddWithValue("@cd", txtCantidad.Text);
                    command.ExecuteNonQuery();
                    connect.Cerrar();
                    connect.abrir();

                    string consulta = "Select * from Detalle Where CodigoFactura = '" + Convert.ToInt16(txtCodFactura.Text) + "'";
                    SqlCommand comando = new SqlCommand(consulta, connect.sc);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dataGridView_OrdenVenta.DataSource = tabla;

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar la columna" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FormFactura factura = new FormFactura();
            factura.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            this.Close();
        }

        private void dataGridView_OrdenVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = e.RowIndex;

            txtCodigo.Text = dataGridView_OrdenVenta.CurrentRow.Cells[1].Value.ToString();
            txtCantidad.Text = dataGridView_OrdenVenta.CurrentRow.Cells[2].Value.ToString();

            cmd = new SqlCommand("Select * from Servicios", connect.sc);

            string consulta = "SELECT * from Servicios WHERE CodigoServicio = '" + Convert.ToInt16(txtCodigo.Text) + "'";
            SqlCommand comando = new SqlCommand(consulta, connect.sc);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                txtCodigo.Text = txtCodigo.Text;
                txtNombre.Text = Convert.ToString((registro["NombreServicio"]));
                txtPrecio.Text = Convert.ToString((registro["PrecioServicio"]));
            }

            connect.Cerrar();
            connect.abrir();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_OrdenVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }



    }
}
