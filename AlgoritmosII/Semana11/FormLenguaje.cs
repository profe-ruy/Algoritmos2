using System;
using System.Windows.Forms;

namespace Semana11
{
    public partial class FormLenguaje : Form
    {
        public FormLenguaje()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {

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
    }
}
