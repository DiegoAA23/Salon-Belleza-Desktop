using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Final_2
{
    internal class clsClientes : clsPersona
    {
        clsConexion connect = new clsConexion();

        private string consulta;
        private string consultan;
        private string borrar;
        public string Consulta { get => consulta; set => consulta = value; }
        public string Consultan { get => consultan; set => consultan = value; }
        public string Borrar { get => borrar; set => borrar = value; }

        override sealed public void AgregarCliente()
        {
            connect.abrir();
            
            SqlCommand cmd = new SqlCommand("Insert into Clientes (NombreCliente,ApellidoCliente,DireccionCliente,FechaNacCliente,TelefonoCliente) Values('" + Nombre + "', '" + Apellido + "', '" + Direccion + "', '" + FechaNac + "', '" + Telefono + "')", connect.sc);
            cmd.ExecuteNonQuery();
        }

        public void ClienteConsulta()
        {
            connect.abrir();
            Consulta = "Select * from Clientes where CodigoCliente = '" + Codigo + "'";
        }

        public void ClienteConsulta(string _nombre)
        {
            connect.abrir();
            Consultan = "Select * from Clientes where NombreCliente = '" + _nombre + "'";
        }

        public void BorrarC()
        {
            Borrar = "DELETE FROM Clientes WHERE CodigoCliente=@cc;";
        }
    }
}
