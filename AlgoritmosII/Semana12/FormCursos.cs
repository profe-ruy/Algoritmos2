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
    public partial class FormCursos : Form
    {
        public FormCursos()
        {
            InitializeComponent();
        }

        private void FormCursos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnMatematica_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMatematica formMatematica = new FormMatematica();
            formMatematica.Show();
        }

        private void btnLenguaje_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLenguaje formLenguaje = new FormLenguaje();
            formLenguaje.Show();
        }
    }
}
