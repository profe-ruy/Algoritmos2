using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana13
{
    public partial class FormTrabajadorPorHoras : Form
    {
        public FormTrabajadorPorHoras()
        {
            InitializeComponent();
        }

        private void FormTrabajadorPorHoras_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
        }
    }
}
