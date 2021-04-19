using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    //aplicamos herencia sobre la clase abstracta
    public class TrabajadorPlanilla : Trabajador
    {
        private double SueldoBase; 
        //constructor con un dato fijo
        public TrabajadorPlanilla(double sueldoBase) : base("Planilla")
        {
            SueldoBase = sueldoBase;
        }

        //implementar el metodo abstracto en los hijos
        public override string CalcularPago()
        {
            string mensaje = "";
            mensaje += "El tipo de trabajador es : " + base.GetTipoTrabajador() + Environment.NewLine;
            mensaje += "El sueldo base es : " + SueldoBase + Environment.NewLine;
            mensaje += "El descuento de AFP es  : " + (SueldoBase * 0.25) + Environment.NewLine;
            mensaje += "El descuento de Quinta Categoria es  : " + (SueldoBase * 0.12) + Environment.NewLine;
            mensaje += "El Sueldo Neto es  : " + (SueldoBase * 0.63) + Environment.NewLine;
            return mensaje;
        }
    }
}
