using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana11
{
    //para heredar en .net utilizamos los dos puntos ":"
    public class CursoFisica : Curso
    {
        public CursoFisica(double notaParcial, double notaFinal):base(notaParcial, notaFinal)
        {
                
        }

        //para sobreescribir el metodo de padre en el hijo, 
        // utilizamos la palabra clave OVERRIDE
        public override double ObtenerPromedio() {
            return 0.30 * NotaParcial + 0.70 * NotaFinal;
        }
    }
}
