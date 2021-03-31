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
            FormListaProductos formLista = new FormListaProductos();
            this.Hide();
            formLista.Show();
        }
    }
}
