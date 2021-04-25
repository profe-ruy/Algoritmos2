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
                double sueldoBruto = double.Parse(txtSueldoBruto.Text);
                //crear una clase de tipo trabajador
                //NO SE PUEDE CREAR UNA INSTANCIA DE UNA CLASE ABSTRACTA
                //Trabajador trabajador = new Trabajador("planilla");

                //crear una clase de tipo trabajador planilla
                TrabajadorPlanilla trabajadorPlanilla = new TrabajadorPlanilla(sueldoBruto);
                //procesar los datos
                string mensaje = trabajadorPlanilla.CalcularPago();
                //mostrar datos
                txtResultado.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, intentalo más tarde");
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
