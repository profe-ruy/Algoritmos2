using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana14
{
    public partial class Form1 : Form
    {
        private List<ITrabajador> trabajadores = new List<ITrabajador>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //obtener datos
                string nombre = txtTrabajador.Text.Trim();
                double sueldoBase = double.Parse(txtSueldo.Text);
                //crear el nuevo objeto trabajador
                ITrabajador trabajador = null;
                //dependiendo el tipo vamos a instanciar el trabajador
                if (cboTipoTrabajador.SelectedIndex == 0)
                    trabajador = new TrabjadorPlanilla(nombre, sueldoBase);
                else
                    trabajador = new TrabajadorHonorarios(nombre, sueldoBase);
                //agregar al listado
                trabajadores.Add(trabajador);
                //listar
                Listar();
            }
            catch (Exception)
            {
                MessageBox.Show("Se encontró un error , intentalo más tarde");
            }
        }

        private void Listar()
        {
            string mensaje = "";
            for (int i = 0; i < trabajadores.Count; i++)
            {
                mensaje += trabajadores[i].GetInformacion() + Environment.NewLine;
            }
            txtListado.Text = mensaje;
        }
    }
}
