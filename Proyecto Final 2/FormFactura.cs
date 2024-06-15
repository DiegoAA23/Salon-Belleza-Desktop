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
    public partial class FormFactura : Form
    {
        public FormFactura()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        SqlCommand cmd;
        clsConexion2 connect2 = new clsConexion2();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=69OIBHP78ow");
        }

        private void FormFactura_Load(object sender, EventArgs e)
        {
            connect.abrir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connect.abrir();

            double desc = 0.25;
            int age=0;

            lblFecha.Text = DateTime.Now.ToString();

            string consulta = "SELECT CodigoEmpleado from Empleados,Detalle WHERE CodigoFactura = '" + Convert.ToInt16(txtCodigoFactura.Text) + "'";
            SqlCommand comando = new SqlCommand(consulta, connect.sc);
            SqlDataReader registro = comando.ExecuteReader();
            while (registro.Read())
            {
                lblVendedor.Text = Convert.ToString((registro["CodigoEmpleado"]));
            }

            connect.Cerrar();
            connect.abrir();

            string suma = "SELECT SUM(PrecioHistorico) as Precio from Detalle WHERE CodigoFactura = '" + Convert.ToInt16(txtCodigoFactura.Text) + "'";
            SqlCommand com = new SqlCommand(suma, connect.sc);
            registro = com.ExecuteReader();
            while (registro.Read())
            {
                lblSubTotal.Text = Convert.ToString((registro["Precio"]));


            }

            connect.Cerrar();
            connect.abrir();

            try
            {
                string servicios = "SELECT S.NombreServicio,D.PrecioHistorico FROM Detalle D INNER JOIN Servicios S ON D.CodServicio = S.CodigoServicio WHERE D.CodigoFactura = '" + Convert.ToInt16(txtCodigoFactura.Text) + "'";
                SqlCommand ayuda = new SqlCommand(servicios, connect.sc);
                SqlDataAdapter data = new SqlDataAdapter(ayuda);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dataGridView1.DataSource = tabla;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connect.Cerrar();
            connect.abrir();

            try
            {
                string edad = "SELECT DATEDIFF(YEAR, FechaNacCliente, GETDATE()) as Edad FROM Clientes WHERE CodigoCliente = '" + Convert.ToInt16(txtCliente.Text) + "'";
                SqlCommand descuento = new SqlCommand(edad, connect.sc);
                registro = descuento.ExecuteReader();
                while (registro.Read())
                {
                    age = Convert.ToInt16((registro["Edad"]));
                    Console.WriteLine(age);
                }

                if (age > 60)
                {
                    lblDescuento.Text = (Convert.ToDouble(lblSubTotal.Text) * desc).ToString("n2");
                }
                else
                {
                    lblDescuento.Text = "0.00";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            lblIVA.Text = ((Convert.ToDouble(lblSubTotal.Text) - Convert.ToDouble(lblDescuento.Text)) * .15).ToString("n2");
            lblTotal.Text = ((Convert.ToDouble(lblSubTotal.Text) - Convert.ToDouble(lblDescuento.Text)) + Convert.ToDouble(lblIVA.Text)).ToString("n2");

            connect.Cerrar();

        }

        private void txtCodigoFactura_Leave(object sender, EventArgs e)
        {
            connect.abrir();
        }

        private void txtCodigoFactura_TextChanged(object sender, EventArgs e)
        {
            connect.abrir();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblVendedor_Click(object sender, EventArgs e)
        {

        }
    }
}
