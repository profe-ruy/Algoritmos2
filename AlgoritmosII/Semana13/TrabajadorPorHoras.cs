using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    public class TrabajadorPorHoras : Trabajador
    {
        private double Horas;
        private double PrecioPorHora;
        public TrabajadorPorHoras(double horas, double precioPorHora) : base("Por Horas")
        {
            Horas = horas;
            PrecioPorHora = precioPorHora;
        }

        //el hijo implementa en especifico un metodo abstracto
        public override string CalcularPago()
        {
            double precioPagar = PrecioPorHora * Horas;
            string mensaje = "";
            mensaje += "El tipo de trabajador es : " + base.GetTipoTrabajador() + Environment.NewLine;
            mensaje += "Trabajo : " + Horas + " Horas " + Environment.NewLine;
            mensaje += "Cobra  : S/." + PrecioPorHora + " por hora " + Environment.NewLine;
            mensaje += "Hay que pagarle  : S/." + (precioPagar) + " en total " + Environment.NewLine;
            mensaje += "Se retiene el 8% para renta de Cuarta  : S/." + precioPagar * 0.08 + "  " + Environment.NewLine;
            mensaje += "Pago neto es  : S/." + precioPagar * 0.92 + "  " + Environment.NewLine;
            return mensaje;
        }
    }
}
