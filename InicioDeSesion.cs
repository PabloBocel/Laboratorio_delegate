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
                string[] usuarioInfo = Inicio.ReadLine().Split(',');

                string correoGuardado = usuarioInfo[0];
                string contrasenaGuardada = usuarioInfo[1];

                if (correoGuardado == TBCorreo.Text && contrasenaGuardada == TBpass.Text)
                {
                    MessageBox.Show("Se inició sesión correctamente");

                    this.Hide();
                    Form1 V1 = new Form1(); // cambiar a la pantalla principal
                    V1.Show();
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
            TBCorreo.Clear();
        }

        private void BTregresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 V1 = new Form1(); // cambiar a la panatalla principal 
            V1.Show();
        }
    }
}
