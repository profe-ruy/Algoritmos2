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
    }
}
