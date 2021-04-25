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
                //lectura de datos
                double precioPorHoras = double.Parse(txtPrecioHora.Text);
                int horas = int.Parse(txtHoras.Text);
                //crear una nueva instancia del trabajador por horas
                TrabajadorPorHoras trabajadorPorHoras = new TrabajadorPorHoras(horas, precioPorHoras);
                //procesar la informacion
                string mensaje = trabajadorPorHoras.CalcularPago();
                //mostrar mensaje 
                txtResultado.Text = mensaje;
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un error, por favor intentelo más tarde");
            }
        }
    }
}
