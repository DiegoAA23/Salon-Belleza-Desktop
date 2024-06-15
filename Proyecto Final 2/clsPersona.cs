using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_2
{
    public class clsPersona
    {
        private string codigo;
        private string nombre;
        private string apellido;
        private string direccion;
        private string fechaNac;
        private string telefono;
        private string correo;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Correo { get => correo; set => correo = value; }


        public void Persona(string codigo, string nombre, string apellido, string direccion, string fechaNac, string telefono, string correo)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            FechaNac = fechaNac;
            Telefono = telefono;
            Correo = correo;
        }

        virtual public void AgregarCliente()
        {

        }


    }
}
