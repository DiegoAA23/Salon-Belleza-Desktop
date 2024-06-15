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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsConexion connect = new clsConexion();
        SqlCommand cmd;

        private void btnAdministrador_Click(object sender, EventArgs e)
        {
            int pst = 0;

            connect.Cerrar();
            connect.abrir();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario='" + textBox1.Text + "' AND PasswordUsuario='" + textBox2.Text + "'", connect.sc);
            DataTable dt = new DataTable(); 
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {

                try
                {
                    string puesto = "SELECT P.CodigoPuesto as Puesto FROM Usuarios U INNER JOIN Empleados E ON U.CodEmpleado = E.CodigoEmpleado INNER JOIN Puestos P ON E.CodPuesto = P.CodigoPuesto WHERE NombreUsuario='" + textBox1.Text + "' AND PasswordUsuario='" + textBox2.Text + "'";
                    SqlCommand acceso = new SqlCommand(puesto, connect.sc);
                    SqlDataReader registro = acceso.ExecuteReader();
                    while (registro.Read())
                    {
                        pst = Convert.ToInt16((registro["Puesto"]));
                    }

                    if(pst == 5)
                    {
                        connect.Cerrar();
                        Form_Cargar boton = new Form_Cargar();
                        boton.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Solamente los GERENTES pueden ingresar como Administrador");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar tabla" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            connect.Cerrar();
            connect.abrir();

            SqlDataAdapter accs = new SqlDataAdapter("SELECT COUNT(*) FROM Usuarios WHERE NombreUsuario='" + textBox1.Text + "' AND PasswordUsuario='" + textBox2.Text + "'", connect.sc);
            DataTable dt = new DataTable();
            accs.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                CargarEmpleado boton = new CargarEmpleado();
                boton.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connect.abrir();
        }
    }
}
