using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana13
{
    //declaro una clase abstracta
    //puede tener implementaciones , pero al menos un metodo tiene q ser abstracto (sin implementacion)
    public abstract class Trabajador
    {
        private string TipoTrabajador;

        public Trabajador(string tipoTrabajador)
        {
            TipoTrabajador = tipoTrabajador;
        }

        protected string GetTipoTrabajador() {
            return TipoTrabajador;
        }

        //declarar un metodo abstracto
        public abstract string CalcularPago();
    }
}
