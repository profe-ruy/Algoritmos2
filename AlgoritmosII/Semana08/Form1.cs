using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana08
{
    public partial class Form1 : Form
    {
        //crear una variable de tipo Repositorio Producto
        RepositorioProducto repositorio = new RepositorioProducto();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //crear un nuevo producto
            int codigo = int.Parse(txtCodigo.Text);
            string descripcion = txtDescripcion.Text.Trim();
            double precio = double.Parse(txtPrecio.Text);
            Producto producto = new Producto(codigo, descripcion, precio);
            //Agregar a la lista
            bool resultado = repositorio.AddProducto(producto);
            //mostrar mensaje dependiendo del resultado
            if (resultado)
            {
                MessageBox.Show("Se agrego un nuevo Producto");
                listar();
                limpiar();
            }
            else
            {
                MessageBox.Show("No se agrego un nuevo Producto");
            }
        }

        private void limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private void listar()
        {
            List<Producto> productos = repositorio.GetProductos();
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
            txtResultado.Text = mensaje;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            //buscar el producto
            Producto producto = repositorio.GetProducto(codigo);
            //verificar si el producto no viene vacio
            if (producto == null) {
                MessageBox.Show("Producto no encontrado");
                return;
            }
            txtDescripcion.Text = producto.GetDescripcion();
            txtPrecio.Text = producto.GetPrecio().ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            //ejecutar el borrar
            bool resultado = repositorio.DeleteProducto(codigo);
            if (resultado)
            {
                MessageBox.Show("Producto Eliminado");
                listar();
            }
            else
            {
                MessageBox.Show("Producto No encontrado");
            }
        }
    }
}
