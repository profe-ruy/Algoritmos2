using System;
using System.Windows.Forms;

namespace Semana05
{
    public partial class Form1 : Form
    {
        int[,] numeros;
        int filas, columnas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            filas = int.Parse(txtFila.Text);
            columnas = int.Parse(txtColumna.Text);
            //inicializar mi arreglo de numeros
            numeros = new int[filas, columnas];
            generarNumeros(filas, columnas);
            //mostrar los datos
            string mensaje = obtenerNumeros();
            txtResultado.Text = mensaje;
        }

        private string obtenerNumeros()
        {
            string mensaje = "";
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    mensaje += "n[" + i + "," + j + "] = " + numeros[i, j] + "\t";
                }
                mensaje += Environment.NewLine;
            }
            return mensaje;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            numeros = null;
            MessageBox.Show("arreglo limpiado");
            txtResultado.Text = "";
        }

        private void btnListarSuma_Click(object sender, EventArgs e)
        {
            int suma = 0;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma += numeros[i, j];
                }
            }
            string mensaje = obtenerNumeros();
            mensaje += "La suma es :" + suma;
            mensaje += Environment.NewLine;
            double promedio = suma * 1.0 / numeros.Length;
            mensaje += "El promedio es : " + promedio;

            txtResultado.Text = mensaje;
        }

        private void btnMayorMenor_Click(object sender, EventArgs e)
        {
            int mayor = 0; int menor = 100;
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (numeros[i, j] < menor) menor = numeros[i, j];
                    if (numeros[i, j] > mayor) mayor = numeros[i, j];
                }
            }

            string mensaje = obtenerNumeros();
            mensaje += "El numero menor  es :" + menor;
            mensaje += Environment.NewLine;
            mensaje += "El numero mayor  es :" + mayor;
            txtResultado.Text = mensaje;
        }

        private void generarNumeros(int filas, int columnas)
        {
            Random random = new Random();
            //recorriendo las filas
            for (int i = 0; i < filas; i++)
            {
                //recorriendo las columnas
                for (int j = 0; j < columnas; j++)
                {
                    numeros[i, j] = random.Next(10, 99);
                }
            }
        }
    }
}
