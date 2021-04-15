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
    }
}
