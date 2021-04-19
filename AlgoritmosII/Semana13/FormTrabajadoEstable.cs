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
    public partial class FormTrabajadoEstable : Form
    {
        public FormTrabajadoEstable()
        {
            InitializeComponent();
        }

        private void FormTrabajadoEstable_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                //leer datos
                double sueldoBase = double.Parse(txtSueldoBruto.Text);
                //Trabajador trabajador = new Trabajador(""); 
                //NO SE PUEDE CREAR UNA INSTANCIA DE LA CLASE ABSTRACTA
                TrabajadorPlanilla trabajadorPlanilla = new TrabajadorPlanilla(sueldoBase);
                //mostrar datos
                string mensaje = trabajadorPlanilla.CalcularPago();
                txtResultado.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, intentelo más tarde");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInicio formInicio = new FormInicio();
            formInicio.Show();
        }
    }
}
