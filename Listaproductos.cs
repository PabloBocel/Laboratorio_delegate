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
    public partial class Listaproductos : Form
    {
        public Listaproductos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public class Producto
        {
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Precio { get; set; }
            public int Cantidad { get; set; }
        }

        private List<Producto> listaProductos = new List<Producto>();

        private void BTAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                string nombreProducto = TBNombreproducto.Text;
                string descripcionProducto = TBDescripcionprod.Text;
                string precioProducto = TBPrecioProd.Text;
                int cantidadProducto = int.Parse(TBcantidad.Text); 

                Producto nuevoProducto = new Producto
                {
                    Nombre = nombreProducto,
                    Descripcion = descripcionProducto,
                    Precio = precioProducto,
                    Cantidad = cantidadProducto 
                };

                listaProductos.Add(nuevoProducto);

                LBproductos.Items.Add(nombreProducto);

                TBNombreproducto.Clear();
                TBDescripcionprod.Clear();
                TBPrecioProd.Clear();
                TBcantidad.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error");
            }
        }

        private void BTBuscarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProductoABuscar = TbConsultarprod.Text;

                Producto productoEncontrado = listaProductos.Find(p => p.Nombre == nombreProductoABuscar);

                if (productoEncontrado != null)
                {
                    MessageBox.Show($"Nombre: {productoEncontrado.Nombre}\n" +
                                    $"Descripción: {productoEncontrado.Descripcion}\n" +
                                    $"Precio: {productoEncontrado.Precio}\n" +
                                    $"Cantidad: {productoEncontrado.Cantidad}",
                                    "Información del Producto");
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.", "Producto no encontrado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error");
            }
        }
    }
}
