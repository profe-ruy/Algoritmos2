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
    }
}
