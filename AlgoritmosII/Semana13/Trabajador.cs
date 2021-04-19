using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    //definimos la clase abstracta
    public abstract class Trabajador
    {
        private string TipoTrabajador;

        public Trabajador(string tipo)
        {
            TipoTrabajador = tipo;
        }

        //un metodo protected con implementacion , que solo lo vean los hijos
        protected string GetTipoTrabajador()
        {
            return TipoTrabajador;
        }

        //debe de tener un metodo abstracto
        public abstract string CalcularPago();
    }
}
