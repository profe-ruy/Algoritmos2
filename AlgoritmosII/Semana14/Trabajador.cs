using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana14
{
    public class Trabajador
    {
        private string Nombre;
        protected double Sueldo;
        private readonly string TipoTrabajador;

        public Trabajador(string nombre, double sueldo, string tipo)
        {
            Nombre = nombre;
            Sueldo = sueldo;
            TipoTrabajador = tipo;
        }



        protected string GetInformacionParcial() {
            return Nombre + "\t\t" + Sueldo + "\t\t" + TipoTrabajador;
        }
    }
}
