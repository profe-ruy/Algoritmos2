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
    public partial class FormMatematica : Form
    {
        public FormMatematica()
        {
            InitializeComponent();
        }

        private void FormMatematica_FormClosing(object sender, FormClosingEventArgs e)
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
                //leer los datos
                double prueba = double.Parse(txtPrueba.Text);
                double parcial = double.Parse(txtParcial.Text);
                double final = double.Parse(txtFinal.Text);
                //crear una clase matematica
                CursoMatematica cursoMatematica = new CursoMatematica(parcial, final, prueba);
                //calcular el promedio
                double promedio = cursoMatematica.ObtenerPromedio();
                //mostrar el promedio
                txtPromedio.Text = promedio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error, favor de verificar");
            }
        }
    }
}
