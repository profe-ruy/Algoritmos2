using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana09
{
    public class RepositorioProductos
    {
        private static List<Producto> productos;
        private readonly ManejadorDeArchivos manejadorDeArchivos;
        private static string ARCHIVO_PRODUCTOS = @"C:\Users\rrojas\source\repos\Algoritmos 2\AlgoritmosII\Semana09\productos.txt";
        public RepositorioProductos()
        {
            manejadorDeArchivos = new ManejadorDeArchivos();
            if (productos == null)
            {
                productos = new List<Producto>();
                CargarProductos();
            }
        }

        private void CargarProductos()
        {
            string texto = manejadorDeArchivos.LeerArchivo(ARCHIVO_PRODUCTOS);
            //empezamos a leer las lineas del archivo de texto
            var lineas = texto.Split(';');

            foreach (string linea in lineas)
            {
                if (!string.IsNullOrEmpty(linea))
                {
                    //lee la linea y crea un nuevo producto
                    var valores = linea.Split(',');
                    Producto producto = new Producto(int.Parse(valores[0]), valores[1], double.Parse(valores[2]));
                    //lo agrego a la lista de objetos
                    productos.Add(producto);
                }
            }
        }

        public bool GrabarProductos()
        {
            string texto = "";
            foreach (Producto item in productos)
            {
                texto += $"{item.GetCodigo()},{item.GetDescripcion()},{item.GetPrecio()};";
            }
            manejadorDeArchivos.GuardarArchivo(ARCHIVO_PRODUCTOS, texto);
            return true;
        }

        public bool AddProducto(Producto producto)
        {
            productos.Add(producto);
            return true;
        }

        public List<Producto> GetProductos()
        {
            return productos;
        }
    }
}
