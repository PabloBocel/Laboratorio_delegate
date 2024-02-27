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
        
        public class Usuario
        {
            public string Correo { get; set; }
            public string Contraseña { get; set; }

            public Usuario(string correo, string contraseña)
            {
                Correo = correo;
                Contraseña = contraseña;
            }
        }

        private List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario("pablo1@gmail.com", "1234"),
            new Usuario("gabriela1@gmail.com", "1234"),
        };
        public InicioDeSesion()
        {
            InitializeComponent();
        }

        private void BTiniciarsesion_Click(object sender, EventArgs e)
        {
            try
            {

                string correoIngresado = TBCorreo.Text;
                string contraseñaIngresada = TBpass.Text;
                Usuario usuario = usuarios.FirstOrDefault(u => u.Correo == correoIngresado && u.Contraseña == contraseñaIngresada);

                if (usuario != null)
                {
                    MessageBox.Show("Se inició sesión correctamente");

                    this.Hide();
                    Listaproductos V1 = new Listaproductos();
                    V1.Show();
                }
                else
                {
                    MessageBox.Show("No se pudo iniciar sesión. Verifique su correo y contraseña.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                TextReader Inicio = new StreamReader(TBnombre.Text + ".txt");
                string[] usuarioInfo = Inicio.ReadLine().Split(',');

                string correoGuardado = usuarioInfo[0];
                string contrasenaGuardada = usuarioInfo[1];

                if (correoGuardado == TBCorreo.Text && contrasenaGuardada == TBpass.Text)
                {
                    MessageBox.Show("Se inició sesión correctamente");

                    this.Hide();
                    Listaproductos V1 = new Listaproductos();
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
            Form1 V1 = new Form1(); 
            V1.Show();
        }

        private void InicioDeSesion_Load(object sender, EventArgs e)
        {

        }

        private void TBpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTCorreo_Click(object sender, EventArgs e)
        {

        }

        private void TBCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TBnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTpassword_Click(object sender, EventArgs e)
        {

        }

        private void BTnombre_Click(object sender, EventArgs e)
        {

        }
    }
}
