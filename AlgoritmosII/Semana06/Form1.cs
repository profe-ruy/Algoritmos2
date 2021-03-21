using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana06
{
    public partial class Form1 : Form
    {
        const int capacity = 3;
        int posicion = 0;
        Producto[] productos = new Producto[capacity];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (posicion >= capacity) { MessageBox.Show("Ya estamos al limite"); return; }
                //leer datos
                int codigo = int.Parse(txtCodigo.Text);
                string descripcion = txtDescripcion.Text.Trim();
                double precio = double.Parse(txtPrecio.Text);
                //crear un nuevo objeto de tipo productos
                Producto producto = new Producto(codigo, descripcion, precio);
                //agregar al arreglo
                productos[posicion] = producto;
                //Mensaje de confirmacion
                MessageBox.Show("Se agrego un producto");
                //aumentar la posicion
                posicion++;
                limpiar();
                string mensaje = listarProductos();
                txtResultado.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, intentelo más tarde");
            }

        }

        private string listarProductos()
        {
            string mensaje = "";
            for (int i = 0; i < productos.Length; i++)
            {
                Producto producto = productos[i];
                if (producto != null)
                {
                    mensaje += "Codigo : " + producto.GetCodigo() + "\t"
                            + "Descripcion : " + producto.GetDescripcion() + "\t\t"
                            + "Precio : " + producto.GetPrecio(); ;
                }
                mensaje += Environment.NewLine;
            }

            return mensaje;
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            Producto producto = null;

            for (int i = 0; i < productos.Length; i++)
            {
                Producto prod = productos[i];
                if (prod != null && prod.GetCodigo() == codigo) {
                    producto = prod;
                    break;
                }
            }

            if (producto != null)
            {
                txtDescripcion.Text = producto.GetDescripcion();
                txtPrecio.Text = producto.GetPrecio().ToString();
            }
            else
            {
                MessageBox.Show("el producto no se encontró");
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            bool fueActualizado = false;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null && productos[i].GetCodigo() == codigo)
                {
                    productos[i].SetDescripcion(txtDescripcion.Text.Trim());
                    productos[i].SetPrecio(double.Parse(txtPrecio.Text));
                    fueActualizado = true;
                    break;
                }
            }
            if (fueActualizado)
            {
                MessageBox.Show("Producto Actualizado");
                string mensaje = listarProductos();
                txtResultado.Text = mensaje;
            }
            else
            {
                MessageBox.Show("el producto no se encontró");
            }
        }

        private void btnAumentar_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null) {
                    productos[i].SetPrecio(productos[i].GetPrecio() * 1.10);
                    contador++;
                }
            }

            if (contador > 0) {
                string mensaje = listarProductos();
                txtResultado.Text = mensaje;
                MessageBox.Show("Se actualizaron " + contador + " productos");
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Producto[] filtrados = new Producto[10];
            int posicionDeFiltrado = 0;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i] != null && productos[i].GetDescripcion().ToLower().StartsWith("r"))
                {
                    filtrados[posicionDeFiltrado] = productos[i];
                    posicionDeFiltrado++;
                }
            }

            if (posicionDeFiltrado > 0)
            {
                MessageBox.Show("se encontraron " + posicionDeFiltrado + " productos con la letra R");
                string mensaje = "";
                for (int i = 0; i < filtrados.Length; i++)
                {
                    Producto producto = filtrados[i];
                    if (producto != null)
                    {
                        mensaje += "Codigo : " + producto.GetCodigo() + "\t"
                                + "Descripcion : " + producto.GetDescripcion() + "\t\t"
                                + "Precio : " + producto.GetPrecio(); ;
                    }
                    mensaje += Environment.NewLine;
                }
                txtResultado.Text = mensaje;
            }
            else
            {
                MessageBox.Show("NO se encontraron  productos con la letra R");
            }
        }
    }
}
