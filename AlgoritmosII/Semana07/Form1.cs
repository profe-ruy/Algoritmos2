using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana07
{
    public partial class Form1 : Form
    {
        //variable global para manejar la lista
        List<Producto> productos = new List<Producto>();
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
                //leer datos
                string descripcion = txtDescripcion.Text.Trim();
                int codigo = int.Parse(txtCodigo.Text);
                double precio = double.Parse(txtPrecio.Text);
                //crear un nuevo producto
                Producto producto = new Producto(codigo, descripcion, precio);
                //agregarlo
                productos.Add(producto);
                //listar la lista d eproductos
                string mensaje = GetLista();
                //mostrar lista
                txtResultado.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show("se genero un error");
            }
        }

        private string GetLista()
        {
            string mensaje = "";
            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                //escribir el mensaje
                mensaje += "Codigo : " + prod.GetCodigo() + "\t"
                           + "Descripcion : " + prod.GetDescripcion() + "\t\t"
                           + "Precio : " + prod.GetPrecio();
                mensaje += Environment.NewLine;
            }
            return mensaje;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            Producto producto = null;

            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                if (prod.GetCodigo() == codigo)
                {
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            bool elementoEncontrado = false;

            

            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                if (prod.GetCodigo() == codigo) {
                    productos.RemoveAt(i);
                    elementoEncontrado = true;
                    break;
                }
            }
            if (elementoEncontrado)
            {
                MessageBox.Show("Elemento eliminado");
                string mensaje = GetLista();
                txtResultado.Text = mensaje;
            }
            else
            {
                MessageBox.Show("Elemento no encontrado");
            }
        }
    }
}
