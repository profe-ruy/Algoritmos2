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
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnPorPlanilla_Click(object sender, EventArgs e)
        {
            FormTrabajadoEstable formTrabajadoEstable = new FormTrabajadoEstable();
            this.Hide();
            formTrabajadoEstable.Show();
        }

        private void btnPorHoras_Click(object sender, EventArgs e)
        {
            FormTrabajadorPorHoras formTrabajadorPorHoras = new FormTrabajadorPorHoras();
            this.Hide();
            formTrabajadorPorHoras.Show();
        }
    }
}
