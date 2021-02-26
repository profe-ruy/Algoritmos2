using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana01_Ejercicio2
{
    public partial class Form1 : Form
    {
        //declarar la variable empleado como global
        Empleado empleado;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Cree la clase empleado dentro del proyecto  y declare los siguientes
            atributos como PRIVADOS: codigo (int), nombre (String), horas (int), tarifa
            (double) e implemente los siguientes métodos:
            a) Un constructor que inicialice a los atributos
            b) Métodos de acceso: set/get para cada atributo
            c) Un método que retorne el sueldo bruto (horas*tarifa)
            d) Un método que retorne el descuento (11% del sueldo bruto)
            e) Un método que retorne el sueldo neto (sueldo bruto - descuento)

            En la clase principal (donde esta la GUI), implemente lo siguiente:
            a) Cree un objeto de tipo empleado con datos fijos.
            b) Cree un método listar que imprima todos los atributos del empleado y el sueldo neto.
            c) Incremente la tarifa del empleado en 10% e imprima su nueva tarifa
             */
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            //primero validar la informacion
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                string nombre = txtNombre.Text;
                int horas = int.Parse(txtHoras.Text);
                double tarifa = double.Parse(txtTarifa.Text);
                //crear nuestro objeto
                empleado = new Empleado(codigo, nombre, horas, tarifa);
                //mensaje de confirmacion
                MessageBox.Show("Empleado creado");
            }
            catch (ArgumentNullException ex)
            {
                MessageBox.Show("Completar todos los campos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingresar valores correctos");
            }
        }

        private void btnListarDatos_Click(object sender, EventArgs e)
        {
            //listar
            string mensaje = "";
            mensaje += "Codigo del empleado " + empleado.GetCodigo() + Environment.NewLine;
            mensaje += "Nombre del empleado " + empleado.GetNombre() + Environment.NewLine;
            mensaje += "Horas Trabajadas del empleado " + empleado.GetHoras() + Environment.NewLine;
            mensaje += "Tarifa del empleado " + empleado.GetTarifa() + Environment.NewLine;
            mensaje += "Sueldo Bruto del empleado " + empleado.GetSueldoBruto() + Environment.NewLine;
            mensaje += "Descuento del empleado " + empleado.GetDescuento() + Environment.NewLine;
            mensaje += "Sueldo Neto del empleado " + empleado.GetSueldoNeto() + Environment.NewLine;
            //mostrar mensaje
            txtResultado.Text = mensaje;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            double tarifaActual = empleado.GetTarifa();
            empleado.SetTarifa(tarifaActual * 1.10);
            //listar los valores antiguos y nuevos
            string mensaje = "";
            mensaje += "La tarifa anterior era :" + tarifaActual + Environment.NewLine;
            mensaje += "La nueva tarifa es:" + empleado.GetTarifa() + Environment.NewLine;
            //mostrar mensaje
            txtResultado.Text = mensaje;
        }
    }
}