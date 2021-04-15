using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11
{
    //para heredar el .net se utiliza los dos puntos ":"
    public class CursoQuimica : Curso
    {
        // tenemos q llamar al constructar de la clase base , con el keyword base 
        // y llamarlo con sus parametros del constructor
        public CursoQuimica(double notaParcial, double notaFinal) : base(notaParcial, notaFinal)
        {

        }
    }
}
