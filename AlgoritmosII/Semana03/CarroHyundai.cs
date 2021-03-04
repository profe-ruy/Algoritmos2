using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03
{
    public class CarroHyundai
    {
        private const string MARCA = "HYUNDAI";
        private const double PRECIO_CARRO = 45000;

        public double GetPrecio()
        {
            return PRECIO_CARRO;
        }


        public string  GetMarca()
        {
            return MARCA;
        }
    }

    public class CarroToyota
    {
        private const string MARCA = "TOYOTA";
        private const double PRECIO_CARRO = 35000;
        public double GetPrecio()
        {
            return PRECIO_CARRO;
        }
        public string GetMarca()
        {
            return MARCA;
        }
    }

    public class CarroMazda
    {
        private const string MARCA = "MAZDA";
        private const double PRECIO_CARRO = 56000;
        public double GetPrecio()
        {
            return PRECIO_CARRO;
        }
        public string GetMarca()
        {
            return MARCA;
        }
    }
}
