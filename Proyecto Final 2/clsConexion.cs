using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public class clsConexion
    {
        SqlDataAdapter da;
        DataTable dt;

        string conexion = " Data Source = LAPTOP-3KI7LCMK; Initial Catalog =  Proyecto_Equipo10; Integrated Security = true ";

        public SqlConnection sc = new SqlConnection();

        public clsConexion()
        {
            sc.ConnectionString = conexion;

        }

        public void abrir()
        {
            try
            {
                if (sc.State == ConnectionState.Closed)
                {
                    sc.Open();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al abrir la conexión");
            }
        }

        public void Cerrar()
        {
            try
            {
                if (sc.State == ConnectionState.Open)
                {
                    sc.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cerrar la conexión");
            }
        }

        public void cargarDatos(DataGridView dgv, string nametable)
        {
            try
            {
                da = new SqlDataAdapter("select * from " + nametable, conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede agregar");
            }
        }
    }
}