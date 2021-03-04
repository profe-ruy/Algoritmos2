using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03
{
    public class Distribuidora
    {
        private readonly CarroHyundai carroHyundai = new CarroHyundai();
        private readonly CarroToyota carroToyota = new CarroToyota();
        private readonly CarroMazda carroMazda = new CarroMazda();

        private readonly int Cantidad;
        private readonly int TipoCarroSeleccionado;
        private double MontoVenta;
        private double PrecioUnitario;

        public Distribuidora(int cantidad, int tipoCarro)
        {
            Cantidad = cantidad;
            TipoCarroSeleccionado = tipoCarro;
            SetValores();
        }

        private void SetValores()
        {
            switch (TipoCarroSeleccionado)
            {
                case 0: PrecioUnitario = carroHyundai.GetPrecio(); break;
                case 1: PrecioUnitario = carroToyota.GetPrecio(); break;
                default: PrecioUnitario = carroMazda.GetPrecio(); break;
            }
            MontoVenta = PrecioUnitario * Cantidad;
        }

        public double GetMontoVenta()
        {
            return MontoVenta;
        }

        public double GetPrecioUnitario()
        {
            return PrecioUnitario;
        }
    }
}
