using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Laboratorio_delegate
{
    public partial class InicioDeSesion : Form
    {
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void BTiniciarsesion_Click(object sender, EventArgs e)
        {
            try
            {
                TextReader Inicio = new StreamReader(TBnombre.Text + ".txt");

                if (Inicio.ReadLine() == TBpass.Text)
                {
                    MessageBox.Show("Se inicio sesion");
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesion");
                }
            }
            catch (Exception z)
            {
                MessageBox.Show("hubo un error" + z, "Error");
            }
        }

        private void BTLimpiar_Click(object sender, EventArgs e)
        {
            TBnombre.Clear();
            TBpass.Clear();
        }

        private void BTregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 V1 = new Form1();
            V1.Show();
        }
    }
}
