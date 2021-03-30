using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana09
{
    public class ManejadorDeArchivos
    {
        public string LeerArchivo(string nombreArchivo)
        {
            StreamReader lector = new StreamReader(nombreArchivo);
            //leer el archivo
            string texto = lector.ReadToEnd();
            //cerrar el vinculo con el archivo
            lector.Close();
            //reescribir la informacion
            texto = texto.Replace("\r\n", string.Empty);
            //retornar el texto
            return texto;
        }

        public void GuardarArchivo(string nombreArchivo, string texto)
        {
            StreamWriter escritor = new StreamWriter(nombreArchivo);
            string[] lineas = texto.Split(';');
            //recorrer el arreglo de lineas
            foreach (string linea in lineas)
            {
                if (!string.IsNullOrEmpty(linea))
                    escritor.WriteLine($"{linea};");
            }
            //cerrar la conexion o vinculo cn nuestro archivo
            escritor.Close();
        }
    }
}
