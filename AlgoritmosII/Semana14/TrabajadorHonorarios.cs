using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana14
{
    public class TrabajadorHonorarios : Trabajador, ITrabajador
    {
        public TrabajadorHonorarios(string nombre, double sueldo) : base(nombre, sueldo, "Trabajador por Honorarios")
        {
            
        }

        public double GetDescuentos()
        {
            return Sueldo * 0.10;
        }

        public double GetSueldoNeto()
        {
            return Sueldo * 0.90;
        }

        public string GetInformacion()
        {
            string infoParcial = base.GetInformacionParcial();
            return infoParcial + "\t\t" + GetDescuentos() + "\t\t" + GetSueldoNeto();
        }
    }
}
