using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12
{
    //hereda de la clase Curso
    public class CursoMatematica : Curso
    {
        //esta propiedad solo pertenece a la clase Matematica
        private double PruebaUnica;
        public CursoMatematica(double parcial, double final, double pruebaUnica): base(parcial, final)
        {
            PruebaUnica = pruebaUnica;
        }

        //este metodo es un metodo polimorfico , porque tiene una sobrecarga
        public double ObtenerPromedio() {
            return base.ObtenerPromedio(PruebaUnica);
        }
    }
}
