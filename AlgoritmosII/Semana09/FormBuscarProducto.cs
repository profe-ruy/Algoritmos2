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
    public partial class FormBuscarProducto : Form
    {
        RepositorioProductos repositorio = new RepositorioProductos();
        public FormBuscarProducto()
        {
            InitializeComponent();
        }

        private void FormBuscarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerrar la aplicacion
            Application.Exit();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int codigo = int.Parse(txtCodigo.Text);
            //buscar el producto
            Producto producto = repositorio.Buscar(codigo);
            if (producto == null) {
                MessageBox.Show("El producto buscado no existe");
                txtDescripcion.Text = "";
                txtPrecio.Text = "";
                return;
            }
            txtDescripcion.Text = producto.GetDescripcion();
            txtPrecio.Text = producto.GetPrecio().ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormListaProductos formLista = new FormListaProductos();
            this.Hide();
            formLista.Show();
        }
    }
}
