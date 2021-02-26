using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01
{
    public class Cuadrado
    {
        public double Lado;

        public Cuadrado(double lado)
        {
            Lado = lado;
        }


        public double GetLado()
        {
            return Lado;
        }

        public double GetArea()
        {
            return Lado * Lado;
        }

        public double GetPerimetro()
        {
            return 4 * Lado;
        }
    }
}
