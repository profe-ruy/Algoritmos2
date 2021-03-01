using System;
using System.Windows.Forms;

namespace Semana01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                double lado = int.Parse(txtLado.Text);
                //crear una nueva instancia de la clase Cuadrado
                
                if (lado <= 0)
                {
                    MessageBox.Show("Ingrea valores mayores que 0 para el lado");
                    return;
                }

                Cuadrado cuadrado = new Cuadrado(lado);
                //proceso de datos
                //double perimetro = 4 * lado;
                //double area = lado * lado;


                //salida de resultado
                string mensaje = "";
                mensaje += "El valor del perimetro del cuadrado es :" + cuadrado.GetPerimetro() + Environment.NewLine;
                mensaje += "El valor del area del cuadrado es :" + cuadrado.GetArea() + Environment.NewLine;
                txtResultado.Text = mensaje;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresa valor numerico para el lado");
            }


        }
    }
}
