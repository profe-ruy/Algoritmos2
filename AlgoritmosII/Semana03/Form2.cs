using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana03
{
    public partial class Form2 : Form
    {
        Vendedor vendedor;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            /*
            
             * 
             * Crear la clase STATIC Manipulador de excepciones (ExceptionHandler), 
             * que contendra un contador de excepciones generadas 
             * Tendra un metodo que genera el mensaje de error
             * 
             * En la UI un formulario en el que ingresara el nombre del vendedor y el monto vendido, 
             * Un botón que creara un nuevo vendedor mostrando un mensaje de confirmación o un mensaje de error de acuerdo al caso
             * Un botón que listara la informacion del ultimo Vendedor y la cantidad de Vendedores creados
             */
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (vendedor == null)
            {
                MessageBox.Show("No hay venededores!");
                return;
            }
            string mensaje = "";
            mensaje += "El codigo del vendedor es : " + vendedor.GetCodigoVendedor() + Environment.NewLine;
            mensaje += "El nombre del vendedor es : " + vendedor.GetNombre() + Environment.NewLine;
            mensaje += "El monto del vendedor es : " + vendedor.GetMonto() + Environment.NewLine;
            mensaje += "La cantidad de vendedores creados es: " + Vendedor.CANTIDAD_DE_VENDEDORES;
            mensaje += "La cantidad de errores creados es: " + ManejadorExcepciones.CANTIDAD_DE_EXCEPCIONES;
            txtResultado.Text = mensaje;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                double monto = double.Parse(txtMonto.Text);
                vendedor = new Vendedor(nombre, monto);
                MessageBox.Show("Vendedor creado!");
            }
            catch (Exception ex)
            {
                string mensaje = ManejadorExcepciones.ManejarExcepciones(ex);
                MessageBox.Show(mensaje);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void limpiarCampos()
        {
            txtMonto.Text = "";
            txtNombre.Text = "";
            txtResultado.Text = "";
        }
    }
}
