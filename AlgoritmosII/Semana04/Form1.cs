using System;
using System.Windows.Forms;

namespace Semana04
{
    public partial class Form1 : Form
    {
        string[] nombres;
        int indice; int capacidad = 5;

        public Form1()
        {
            InitializeComponent();
            nombres = new string[capacidad];
            indice = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //dato
            if (indice == capacidad)
            {
                MessageBox.Show("Arreglo en su máxima capacidad");
                return;
            }
            string nombre = txtNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingresa un nombre");
                return;
            }
            nombre = nombre.ToLower();
            if (nombre.StartsWith("x"))
            {
                MessageBox.Show("Ingresa un nombre sin X al inicio");
                return;
            }
            //agregar el nombre a la lista
            nombres[indice] = nombre;
            //aumentar la posicion
            indice++;
            MessageBox.Show("elemento agreado");
        }

        private void Listar()
        {
            string mensaje = "";
            for (int i = 0; i < nombres.Length; i++)
            {
                mensaje += "[" + i + "] : " + nombres[i] + Environment.NewLine;
            }
            txtLista.Text = mensaje;
        }

        private void btnListarTodo_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtLista.Text = "";
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            int indiceParaBuscar = int.Parse(txtIndice.Text);
            if (indiceParaBuscar > capacidad || indiceParaBuscar < 0)
            {
                MessageBox.Show("El indice buscado no existe");
                return;
            }
            string nombre = nombres[indiceParaBuscar];

            txtLista.Text = nombre;
        }

        private void btnBorrarSegunPosicion_Click(object sender, EventArgs e)
        {
            int indiceParaBuscar = int.Parse(txtIndice.Text);
            if (indiceParaBuscar > capacidad || indiceParaBuscar < 0)
            {
                MessageBox.Show("El indice buscado no existe");
                return;
            }
            nombres[indiceParaBuscar] = null;
            MessageBox.Show("Elemento eliminado");
            Listar();
        }

        private void txtActualizar_Click(object sender, EventArgs e)
        {
            int indiceParaBuscar = int.Parse(txtIndice.Text);
            if (indiceParaBuscar > capacidad || indiceParaBuscar < 0)
            {
                MessageBox.Show("El indice buscado no existe");
                return;
            }
            string nombre = txtNombre.Text.Trim();
            nombres[indiceParaBuscar] = nombre;
            MessageBox.Show("Elemento Actualizado");
            Listar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nombres = new string[capacidad];
            Listar();
        }
    }
}
