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
    public partial class FormAgregarProducto : Form
    {
        RepositorioProductos repositorio = new RepositorioProductos();
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //leer datos
            int codigo = int.Parse(txtCodigo.Text);
            string descripcion = txtDescripcion.Text.Trim();
            double precio = double.Parse(txtPrecio.Text);
            //crear un nuevo producto
            Producto producto = new Producto(codigo, descripcion, precio);
            //agregar el producto a la lista
            bool resultado = repositorio.AgregarProducto(producto);
            if (resultado)
                MessageBox.Show("Producto agregado");
            else
                MessageBox.Show("Producto NO agregado");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //crear el formulario de Lista
            FormListaProductos formLista = new FormListaProductos();
            //ocultar el formulario actual
            this.Hide();
            //mostrar el nuevo formulario
            formLista.Show();
        }

        private void FormAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
