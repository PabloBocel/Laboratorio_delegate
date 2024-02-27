using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTregistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro ventanaUsuario = new Registro(); 
            ventanaUsuario.Show();
        }

        private void BTiniciosesion_Click(object sender, EventArgs e)
        {
            this.Hide();
            InicioDeSesion VentanaIniciodeSesion = new InicioDeSesion();
            VentanaIniciodeSesion.Show();
        }
    }
}
