using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana11
{
    public partial class FormQuimica : Form
    {
        public FormQuimica()
        {
            InitializeComponent();
        }

        private void FormQuimica_FormClosing(object sender, FormClosingEventArgs e)
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
                double notaParcial = double.Parse(txtParcial.Text);
                double notaFinal = double.Parse(txtFinal.Text);
                //crear nuestro objeto curso Quimica
                CursoQuimica cursoQuimica = new CursoQuimica(notaParcial, notaFinal);
                //procesar el promedio
                double promedio = cursoQuimica.ObtenerPromedio();
                //salida de datos
                txtPromedio.Text = promedio.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error, favor de verificar");
            }
        }
    }
}
