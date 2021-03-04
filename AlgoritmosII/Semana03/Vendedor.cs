using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03
{
    public class Vendedor
    {
        /*
          * Cree la clase Vendedor , con las propiedades PRIVADAS Nombre (string) , Monto Vendido (double)
             * Los requisitos son que el nombre de Vendedor no empieze con X 
             * y que su nombre no tenga más de 10 caracteres,de lo contrario generar un ArgumentException
             * El monto Vendido no puede ser menor que 0 , de lo contrario generar un ArgumentOutOfRangeException
             * Un metodo que expondra el codigo del usuario con el siguiente formato "V001" , "V002" , "V003" 
             * Donde los ultimos digitos sean formado por el # de vendedores
             * Un contador estatico de la cantidad de Vendedores creados
         */

        private string Nombre;
        private double MontoVendido;
        public static int CANTIDAD_DE_VENDEDORES = 0;

        public Vendedor(string nombre, double monto)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentException();

            if (nombre.StartsWith("x") || nombre.StartsWith("X"))
                throw new ArgumentException();

            if (nombre.Length > 10)
                throw new ArgumentException();

            if (monto <= 0)
                throw new ArgumentOutOfRangeException();

            Nombre = nombre;
            MontoVendido = monto;
            CANTIDAD_DE_VENDEDORES++;
        }

        public string GetCodigoVendedor()
        {
            return "V" + CANTIDAD_DE_VENDEDORES.ToString().PadLeft(3, '0');
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public double GetMonto()
        {
            return MontoVendido;
        }

    }
}
