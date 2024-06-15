using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_2
{
    public partial class Form_Cargar : Form
    {
        public Form_Cargar()
        {
            InitializeComponent();
        }

        private void Form_Cargar_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProcesBar.Value < 100)
            {
                ProcesBar.Value += 10;

                lbldone.Text = ProcesBar.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();

                lbldone.Text = "¡Done!";
            }
        }

        private void btnstart_Click(object sender, EventArgs e)
        {
            Form_MenuAdministrador admin = new Form_MenuAdministrador();
            admin.ShowDialog();
        }

        private void lbldone_Click(object sender, EventArgs e)
        {

        }
    }
}
