using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    //indica la herencia sobre la clase abstracta trabajador
    public class TrabajadorPorHoras : Trabajador
    {
        private int Horas;
        private double PrecioPorHoras;
        public TrabajadorPorHoras(int horas, double precioHoras):base("Por horas")
        {
            Horas = horas;
            PrecioPorHoras = precioHoras;
        }

        //sobre escritura del metodo abstracto
        public override string CalcularPago()
        {
            double precioPagar = PrecioPorHoras * Horas;
            string mensaje = "";
            mensaje += "El tipo de trabajador  es : " + base.GetTipoTrabajador() + Environment.NewLine;
            mensaje += "Trabajó : " + Horas + " Horas" + Environment.NewLine;
            mensaje += "Cobra S/. : " + PrecioPorHoras + " por hora" + Environment.NewLine;
            mensaje += "Hay que pagarle en total " + precioPagar + Environment.NewLine;
            mensaje += "Se le retiene por renta de cuarta el 8% que es " + (0.08 * precioPagar) + Environment.NewLine;
            mensaje += "Su pago neto es  " + (0.92 * precioPagar) + Environment.NewLine;

            return mensaje;
        }
    }
}
