using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana02
{
    /*
            Una heladería vende helados a los precios unitarios dados en la siguiente tabla: 
           |        Helado         |       Precio Unitario        |
           |        Sol            |           S/1.50             |
           |        Fresa          |           S/2.00             |
           |        Mar            |           S/1.70             |
           |        Rico           |           S/2.50             |
           |        Otros          |           S/3.50             |
           Adicionalmente ver si se aplica descuento o no la cual es de (8%)
           - Diseñe un programa que realice la venta
           - Un metodo que liste  la boleta de Venta, siempre y cuando exista, 
             en la cual muestre el reporte Fecha de Venta, Monto a venta, si se aplico descuento o no y monto Neto
           - Un metodo que borre la informacion de la venta
            */
    public class Venta
    {
        private int TipoHelado;
        private int Cantidad;
        private double MontoPagar;
        private double MontoPagarFinal;
        private double Descuento;
        private bool HayDescuento;
        private string FechaVenta;

        //creando constantes
        private const double PRECIO_HELADO_SOL = 1.50;
        private const double PRECIO_HELADO_FRESA = 2.00;
        private const double PRECIO_HELADO_MAR = 1.70;
        private const double PRECIO_HELADO_RICO = 2.50;
        private const double PRECIO_HELADO_OTROS = 3.50;
        private const double PRECIO_DESCUENTO = 0.08;

        //constructor
        public Venta(int tipoHelado, int cantidad, bool hayDescuento, string fechaVenta)
        {
            if (cantidad <= 0) throw new InvalidCastException();
            TipoHelado = tipoHelado;
            Cantidad = cantidad;
            HayDescuento = hayDescuento;
            FechaVenta = fechaVenta;
            SetValores();
        }

        private void SetValores()
        {
            switch (TipoHelado)
            {
                case 0: MontoPagar = PRECIO_HELADO_SOL * Cantidad; break;
                case 1: MontoPagar = PRECIO_HELADO_FRESA * Cantidad; break;
                case 2: MontoPagar = PRECIO_HELADO_MAR * Cantidad; break;
                case 3: MontoPagar = PRECIO_HELADO_RICO * Cantidad; break;
                default: MontoPagar = PRECIO_HELADO_OTROS * Cantidad; break;
            }
            if (HayDescuento)
            {
                Descuento = PRECIO_DESCUENTO * MontoPagar;
            }
            MontoPagarFinal = MontoPagar - Descuento;
        }

        public double GetMontoPagar()
        {
            return MontoPagar;
        }
        public double GetMontoPagarFinal()
        {
            return MontoPagarFinal;
        }

        public string GetFechaVenta() {
            return FechaVenta;
        }
        public bool HuboDescuento() { return HayDescuento; }

    }
}
