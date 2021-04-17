using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana12
{
    //clase base para almacenar la informacion de un curso
    public class Curso
    {
        private double Parcial;
        private double Final;

        public Curso(double parcial, double final)
        {
            Parcial = parcial;
            Final = final;
        }

        //crear metodos protected que calculen el promedio 
        protected double ObtenerPromedio(double pruebaUnica)
        {
            return 0.20 * pruebaUnica + 0.30 * Parcial + 0.50 * Final;
        }

        //este metodo tbm es polimorfico, xq este metodo ya existe, pero este tiene dos parametros ,
        protected double ObtenerPromedio(double prueba, double lectura)
        {
            return 0.10 * prueba + 0.20 * Parcial + 0.30 * lectura + 0.40 * Final;
        }
    }
}
