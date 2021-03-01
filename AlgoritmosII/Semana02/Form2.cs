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
    public partial class Form2 : Form
    {
        //crear nuestro objeto Venta
        Venta venta;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            try
            {
                //leer datos
                int tipoHelado = cboTipoHelado.SelectedIndex;
                int cantidad = int.Parse(txtCantidad.Text);
                bool hayDescuento = chkDescuento.Checked;
                string fechaVenta = dtpFecha.Value.ToString("dd-MM-yyyy");
                //crear mi objeto venta
                venta = new Venta(tipoHelado, cantidad, hayDescuento, fechaVenta);
            }
            catch (InvalidCastException) {
                MessageBox.Show("Ingrese cantidad mayor que 0");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingresar datos correctos");
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (venta == null)
            {
                MessageBox.Show("Ingresar datos de venta");
                return;
            }
            //obtener datos del mensaje
            string mensaje = "";
            mensaje += "La fecha de la venta fue en " + venta.GetFechaVenta() + Environment.NewLine;
            mensaje += "El monto de la venta fue : " + venta.GetMontoPagar() + Environment.NewLine;
            mensaje +=  (venta.HuboDescuento() ? "si hubo descuento" : "NO hubo descuento" ) + Environment.NewLine;
            mensaje += "El monto final de la venta fue : " + venta.GetMontoPagarFinal() + Environment.NewLine;
            //mostrar mensaje
            txtResultado.Text = mensaje;

        }
    }
}
