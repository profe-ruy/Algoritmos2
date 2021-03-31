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
    public partial class FormEliminarProducto : Form
    {
        RepositorioProductos repositorio = new RepositorioProductos();
        public FormEliminarProducto()
        {
            InitializeComponent();
        }

        private void FormEliminarProducto_FormClosing(object sender, FormClosingEventArgs e)
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
            //habilitamos el boton de eliminar siempre y cuando exista el producto
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            //llamar al eliminar
            bool resultado = repositorio.Eliminar(codigo);
            if (resultado)
            {
                Limpiar();
                MessageBox.Show("Producto eliminado!");
                IrAlListar();
            }
            else
            {
                MessageBox.Show("Producto no eliminado!");
            }
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            btnEliminar.Enabled = false;
        }
    }
}
