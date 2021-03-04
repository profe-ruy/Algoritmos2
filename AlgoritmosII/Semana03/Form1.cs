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
    public partial class Form1 : Form
    {
        Distribuidora distribuidora;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             Una tienda vende tres tipos de carros cuyas marcas son : Hyundai , Toyota, MAzda 
             los precios unitarios dados en la siguiente tabla: 
                   | Código                 |    Precio Unitario
                   | Hyundai                |      S/. 45,000.00
                   | Toyota                 |      S/. 35,000.00
                   | Mazda                  |      S/. 56,000.00
            - Cree 3 clases de Carro de acuerdo a la marca, con las propieaddes privadas constantes del precio y nombre
            - Cree una clase Distribuidora, donde referencie los tipos de carro de manera readonly
            Tenga un metodo que genere una venta y asigne el precio de Venta basado en la cantidad  de carros
            - En la GUI diseñe el programa donde se realice una venta de carros ingresando la cantidad y seleccionando el tipo
              y otra funcion que permita Listar la informacion de la venta
             */

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int cantidad = int.Parse(txtCantidad.Text);
                int tipoCarro = cboTipoCarro.SelectedIndex;
                distribuidora = new Distribuidora(cantidad, tipoCarro);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese valores correctos");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //listar la informacion
            string mensaje = "";
            mensaje += "El precio unitario es  :" + distribuidora.GetPrecioUnitario() + Environment.NewLine;
            mensaje += "El monto a pagar es  :" + distribuidora.GetMontoVenta() + Environment.NewLine;
            //mostrar mensaje
            txtResultado.Text = mensaje;
        }
    }
}
