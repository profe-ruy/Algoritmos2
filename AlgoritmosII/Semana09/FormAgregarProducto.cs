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
        RepositorioProductos repo = new RepositorioProductos();
        public FormAgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FormListaProductos formListaProductos = new FormListaProductos();
            this.Hide();
            formListaProductos.Show();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var producto = new Producto(1, "aa", 12.1);
            var resultado = repo.AddProducto(producto);
            if (resultado) {
                MessageBox.Show("Producto Agregado!");
            }
            else
                MessageBox.Show("Producto NO Agregado!");
        }

        private void FormAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            repo.GrabarProductos();
            Application.Exit();
        }
    }
}
