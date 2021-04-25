using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    //aplica herencia sobre una clase abstracta
    public class TrabajadorPlanilla : Trabajador
    {
        private double SueldoBruto;
        //llamada al constructor de la clase padre utilizando el keyword base
        public TrabajadorPlanilla(double sueldoBruto) :base("Planilla")
        {
            SueldoBruto = sueldoBruto;
        }

        //implementamos la funcion abstracta
        public override string CalcularPago()
        {
            double descuentoAFP = 0.25 * SueldoBruto;
            double descuentoQuintaCategoria = 0.12 * SueldoBruto;
            double sueldoNeto = 0.63 * SueldoBruto;

            string mensaje = "";
            mensaje += "El tipo de trabajador  es : " + base.GetTipoTrabajador() + Environment.NewLine;
            mensaje += "El descuento de AFP es: " + descuentoAFP + Environment.NewLine;
            mensaje += "El descuento de Quinta Categoria es: " + descuentoQuintaCategoria + Environment.NewLine;
            mensaje += "El sueldo neto es: " + sueldoNeto + Environment.NewLine;

            return mensaje; 
        }
    }
}
