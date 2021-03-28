﻿using System;
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
            string texto = lector.ReadToEnd();
            lector.Close();
            return texto;
        }

        public void GuardarArchivo(string nombreArchivo, string texto)
        {
            FileStream stream = new FileStream(nombreArchivo, FileMode.OpenOrCreate);
            var lineas = texto.Split(';');
            StreamWriter escritor = new StreamWriter(stream);
            foreach (var linea in lineas)
            {
                if(!string.IsNullOrEmpty(linea))
                    escritor.WriteLine($"{linea};");
            }
            escritor.Close();
        }
    }
}
