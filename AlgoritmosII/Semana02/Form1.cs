using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana02
{
    public partial class Form1 : Form
    {
        //convierto en global mi variable Vendedor
        Vendedor vendedor;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Una empresa paga a sus vendedores un sueldo básico mensual de S/.300. El
            sueldo bruto es igual al sueldo básico más una comisión, que es igual al 9% del
            monto total vendido. Por ley, todo vendedor se somete a un descuento del 11%.
            Diseñe un programa que calcule la comisión, el sueldo bruto, el descuento y el
            sueldo neto de un vendedor de la empresa. 
             */
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            try
            {
                //leer datos
                double montoVentas = double.Parse(txtMontoVenta.Text);
                //inicializar un nuevo objeto
                vendedor = new Vendedor(montoVentas);
                //listar la informacion
                string mensaje = "";
                mensaje += "El sueldo base es " + vendedor.GetSueldoBase() + Environment.NewLine;
                mensaje += "El descuento es " + vendedor.GetDescuento() + Environment.NewLine;
                mensaje += "El sueldo neto es " + vendedor.GetSueldoNeto() + Environment.NewLine;
                //mostrar mensaje;
                txtResultado.Text = mensaje;
            }
            catch (Exception)
            {
                MessageBox.Show("Monto incorrecto");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            vendedor = null;
            MessageBox.Show("Información Eliminada");
            txtResultado.Text = "";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (vendedor == null)
            {
                MessageBox.Show("Informacion no disponible");
                return;
            }
            try
            {
                //leer datos
                double montoVentas = double.Parse(txtMontoVenta.Text);
                //inicializar un nuevo objeto
                vendedor.SetMontoVentas(montoVentas);
                //listar la informacion
                string mensaje = "";
                mensaje += "El sueldo base es " + vendedor.GetSueldoBase() + Environment.NewLine;
                mensaje += "El descuento es " + vendedor.GetDescuento() + Environment.NewLine;
                mensaje += "El sueldo neto es " + vendedor.GetSueldoNeto() + Environment.NewLine;
                //mostrar mensaje;
                txtResultado.Text = mensaje;
            }
            catch (Exception)
            {
                MessageBox.Show("Monto incorrecto");
            }
        }
    }
}
