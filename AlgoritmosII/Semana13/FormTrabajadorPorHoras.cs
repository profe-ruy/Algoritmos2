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

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                double horas = double.Parse(txtHoras.Text);
                double precioPorHora = double.Parse(txtPrecioHora.Text);
                //Crear clase Trabajador por Horas
                TrabajadorPorHoras trabajadorPorHoras = new TrabajadorPorHoras(horas, precioPorHora);
                //procesar
                string mensaje = trabajadorPorHoras.CalcularPago();
                //mostrar mensaje
                txtResultado.Text = mensaje;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, intentarlo más tarde ");
            }
        }
    }
}
