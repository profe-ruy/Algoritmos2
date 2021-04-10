using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana10
{
    public partial class FormLenguaje : Form
    {
        public FormLenguaje()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCursos formCursos = new FormCursos();
            formCursos.Show();
        }

        private void FormLenguaje_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                //leer datos
                double prueba1 = double.Parse(txtPractica1.Text);
                double prueba2 = double.Parse(txtPractica2.Text);
                double prueba3 = double.Parse(txtPractica3.Text);
                double parcial = double.Parse(txtParcial.Text);
                double final = double.Parse(txtFinal.Text);
                //Crear nuestro curso Lenguaje
                CursoLenguaje curso = new CursoLenguaje(prueba1, prueba2, prueba3, parcial, final);
                //calcular el promedio
                double promedio = curso.CalcularPromedio();
                //mostrar mensaje
                txtPromedio.Text = promedio.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error, intentelo más tarde");
            }
        }
    }
}
