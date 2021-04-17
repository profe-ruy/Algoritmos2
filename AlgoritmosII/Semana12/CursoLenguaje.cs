using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12
{
    //aplicamos la herencia hacia la clase Curso
    public class CursoLenguaje : Curso
    {
        private double Prueba;
        private double Lectura;
        
        //nuestro constructor
        public CursoLenguaje(double prueba, double lectura, double parcial, double final) : base(parcial, final)
        {
            Prueba = prueba;
            Lectura = lectura;
        }

        //crear un metodo que calcule el promedio de la clase
        public double ObtenerPromedio() {
            return base.ObtenerPromedio(lectura: Lectura, prueba: Prueba);
            //return base.ObtenerPromedio(Prueba, Lectura);
        }
    }
}
