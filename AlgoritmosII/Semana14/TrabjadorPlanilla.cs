using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana14
{
    public class TrabjadorPlanilla : Trabajador, ITrabajador
    {
        public TrabjadorPlanilla(string nombre, double sueldo) : base(nombre, sueldo, "Trabajador en Planilla")
        {
            
        }

        public double GetDescuentos()
        {
            return 0.25 * Sueldo;
        }

        public double GetSueldoNeto()
        {
            return 0.75 * Sueldo;
        }

        public string GetInformacion()
        {
            string infoParcial = base.GetInformacionParcial();
            return infoParcial + "\t\t" + GetDescuentos() + "\t\t" + GetSueldoNeto();
        }
    }
}
