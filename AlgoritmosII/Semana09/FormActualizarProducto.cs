using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana09
{
    public partial class FormActualizarProducto : Form
    {
        RepositorioProductos repositorio = new RepositorioProductos();
        public FormActualizarProducto()
        {
            InitializeComponent();
        }

        private void FormActualizarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerrar la aplicacion
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            IrAlListar();
        }

        private void IrAlListar()
        {
            FormListaProductos formLista = new FormListaProductos();
            this.Hide();
            formLista.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            //buscar el producto
            Producto producto = repositorio.Buscar(codigo);
            if (producto == null)
            {
                MessageBox.Show("El producto buscado no existe");
                Limpiar();
                return;
            }
            txtDescripcion.Text = producto.GetDescripcion();
            txtPrecio.Text = producto.GetPrecio().ToString();
            //habilitamos el boton de actualizar siempre y cuando exista el producto
            txtPrecio.Enabled = true;
            txtDescripcion.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtPrecio.Enabled = false;
            txtDescripcion.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //leer datos
            int codigo = int.Parse(txtCodigo.Text);
            string descripcion = txtDescripcion.Text.Trim();
            double precio = double.Parse(txtPrecio.Text);
            //crear un nuevo producto
            Producto producto = new Producto(codigo, descripcion, precio);
            //agregar el producto a la lista
            bool resultado = repositorio.ActualizarProducto(producto);
            if (resultado)
            {
                Limpiar();
                MessageBox.Show("Producto actualizado");
                //regresar al listado para ver actualizada la lista
                IrAlListar();
            }
            else
                MessageBox.Show("Producto NO actualizado");
        }
    }
}
