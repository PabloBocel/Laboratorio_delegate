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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace Laboratorio_delegate
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBnombre.Clear();
            TBpass.Clear();
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            try
            {
                TextWriter RegistrarUsuario = new StreamWriter(@"D:\Universidad\Tercer ciclo\Estructura de datos I\Lab\Proyectos\Laboratorio_delegate\bin\Debug\" + TBnombre.Text + ".txt", true);
                RegistrarUsuario.WriteLine(TBpass.Text);
                RegistrarUsuario.Close();

                MessageBox.Show("se regirstro correctamente");

                this.Hide();
                Form1 V1 = new Form1();
                V1.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show("Hubo un error" + x, "Error");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 V1 = new Form1();
            V1.Show();
        }
    }
}
