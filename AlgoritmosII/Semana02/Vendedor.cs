using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    public class Vendedor
    {
        private double MontoVentas;
        private const double MontoBase = 300;
        private double SueldoBase;
        private double MontoDescuento;
        private double SueldoNeto;

        public Vendedor(double montoVentas)
        {
            MontoVentas = montoVentas;
            SetValores();
        }

        public void SetMontoVentas(double nuevoMontoVentas) {
            MontoVentas = nuevoMontoVentas;
            SetValores();
        }

        private void SetValores()
        {
            SueldoBase = MontoBase + 0.09 * MontoVentas;
            MontoDescuento = 0.11 * SueldoBase;
            SueldoNeto = SueldoBase - MontoDescuento;
        }

        public double GetSueldoBase() {
            return SueldoBase;
        }

        public double GetDescuento() {
            return MontoDescuento;
        }

        public double GetSueldoNeto() {
            return SueldoNeto;
        }
    }
}
