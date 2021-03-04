using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana03
{
    public static class ManejadorExcepciones
    {
        public static int CANTIDAD_DE_EXCEPCIONES = 0;

        public static string ManejarExcepciones(Exception ex)
        {
            CANTIDAD_DE_EXCEPCIONES++;
            if (ex is ArgumentOutOfRangeException)
                return "Ingresar valores correctos para el monto";

            if (ex is ArgumentException)
                return "Ingresar valores correctos para el nombre";

            return ex.Message;
        }
    }
}
