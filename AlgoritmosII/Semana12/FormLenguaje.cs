using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana12
{
    public partial class FormLenguaje : Form
    {
        public FormLenguaje()
        {
            InitializeComponent();
        }

        private void FormLenguaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCursos formCursos = new FormCursos();
            formCursos.Show();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                //leer datos 
                double prueba = double.Parse(txtPrueba.Text);
                double parcial = double.Parse(txtParcial.Text);
                double lectura = double.Parse(txtLectura.Text);
                double final = double.Parse(txtFinal.Text);
                //crear el objeto curso Lenguaje
                CursoLenguaje cursoLenguaje = new CursoLenguaje(prueba, lectura, parcial, final);
                //obtener el promedio
                double promedio = cursoLenguaje.ObtenerPromedio();
                //mostrar datos
                txtPromedio.Text = promedio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, favor de verificar");
            }
        }
    }
}
