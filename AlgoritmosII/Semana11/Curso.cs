using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11
{
    public class Curso
    {
        //private double NotaParcial;
        //private double NotaFinal;
        //la palabra reservada protected, es utilizado en herencia
        //para que los hijos puedan ver los atributos/metodos del padre
        protected double NotaParcial;
        protected double NotaFinal;

        //declaramos nuestro constructor
        public Curso(double notaParcial, double notaFinal)
        {
            NotaParcial = notaParcial;
            NotaFinal = notaFinal;
        }

        //crear nuestro metodo para calcular el promedio
        //VIRTUAL indica que se puede sobre escribir en los hijos , de ser necesario
        public virtual double ObtenerPromedio() {
            return 0.50 * NotaParcial + 0.50 * NotaFinal;
        }
    }
}
