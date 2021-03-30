﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana09
{
    public partial class FormListaProductos : Form
    {
        private RepositorioProductos repositorio = new RepositorioProductos();

        public FormListaProductos()
        {
            InitializeComponent();
        }

        private void FormListaProductos_Load(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void ListarProductos()
        {
            txtResultado.Text = repositorio.GetProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //declarar el formulario de crear producto
            FormAgregarProducto formAgregarProducto = new FormAgregarProducto();
            //ocultar nuestro formulario actual
            this.Hide();
            //mostrar el nuevo formulario
            formAgregarProducto.Show();
        }

        private void FormListaProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cerrar la aplicacion
            Application.Exit();
        }
    }
}
