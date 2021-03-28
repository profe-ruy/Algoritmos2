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
    public partial class FormListaProductos : Form
    {
        RepositorioProductos repositorio = new RepositorioProductos();
        public FormListaProductos()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto();
            this.Hide();
            formAgregarProducto.Show();
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            var productos = repositorio.GetProductos();
        }
    }
}
