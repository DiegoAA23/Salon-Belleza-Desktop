using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_2
{
    public class clsEmpleado : clsPersona
    {
        private int codigoPuesto;
        public int CodigoPuesto { get => codigoPuesto; set => codigoPuesto = value; }

        public void Empleado(int codigoPuesto)
        {
            CodigoPuesto = codigoPuesto;
        }




    }
}
