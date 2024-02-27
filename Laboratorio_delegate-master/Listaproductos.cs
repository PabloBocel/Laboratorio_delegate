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

                LBproductos.Items.Add($"{nombreProducto} - Cantidad: {cantidadProducto}");

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

        private void BTCompras_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = TBCompras.Text;
                int cantidadComprar = int.Parse(TBCompraNum.Text); 

                Producto productoEncontrado = listaProductos.Find(p => p.Nombre == nombreProducto);

                if (productoEncontrado != null)
                {
                    if (productoEncontrado.Cantidad >= cantidadComprar)
                    {
                        productoEncontrado.Cantidad += cantidadComprar;
                    }

                    if (productoEncontrado.Cantidad < 0)
                    {
                        productoEncontrado.Cantidad = 0;
                    }

                    MessageBox.Show($"Se agregaron {cantidadComprar} unidades al producto '{nombreProducto}'.",
                                    "Compra Exitosa");

                    ActualizarListBoxProductos();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.", "Producto no encontrado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para la cantidad.", "Error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error");
            }
        }
        private void ActualizarListBoxProductos()
        {
            LBproductos.Items.Clear();

            foreach (Producto producto in listaProductos)
            {
                LBproductos.Items.Add($"{producto.Nombre} - Cantidad: {producto.Cantidad}");

                if (producto.Cantidad <= 2)
                {
                    MessageBox.Show($"¡Atención! La cantidad de {producto.Nombre} está llegando a un nivel crítico.", "Nivel Crítico");
                }
            }
        }

        private void BTVentas_Click(object sender, EventArgs e)
        {
            try
            {
                string nombreProducto = TBVentas.Text;
                int cantidadVender = int.Parse(TBVentaNum.Text);

                Producto productoEncontrado = listaProductos.Find(p => p.Nombre == nombreProducto);

                if (productoEncontrado != null)
                {
                    if (productoEncontrado.Cantidad >= cantidadVender)
                    {
                        productoEncontrado.Cantidad -= cantidadVender;
                    }

                    if (productoEncontrado.Cantidad < 0)
                    {
                        productoEncontrado.Cantidad = 0;
                    }

                    MessageBox.Show($"Se vendieron {cantidadVender} unidades al producto '{nombreProducto}'.",
                                    "venta Exitosa");

                    ActualizarListBoxProductos();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con ese nombre.", "Producto no encontrado");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Ingrese un número válido para la cantidad.", "Error de formato");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error: " + ex.Message, "Error");
            }
        }

        private void BTSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por visitar la tienda.", "Despedida");
            Application.Exit();
        }

        private void Listaproductos_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void LBproductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
