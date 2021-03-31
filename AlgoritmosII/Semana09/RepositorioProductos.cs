using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana09
{
    public class RepositorioProductos
    {
        private List<Producto> productos;
        private const string ARCHIVO_PRODUCTOS = @"C:\Users\rrojas\source\repos\Algoritmos 2\AlgoritmosII\Semana09\productos.txt";
        private ManejadorDeArchivos manejadorDeArchivos = new ManejadorDeArchivos();

        public RepositorioProductos()
        {
            productos = new List<Producto>();
            CargarData();
        }

        private void CargarData()
        {
            string texto = manejadorDeArchivos.LeerArchivo(ARCHIVO_PRODUCTOS);
            //romper las lineas por el separador de linea
            string[] lineas = texto.Split(';');
            //vamos a iterar las lineas para crear nuestro producto
            foreach (string linea in lineas)
            {
                //verificar si la linea tiene valor 
                if (!string.IsNullOrEmpty(linea))
                {
                    //leer linea por linea
                    string[] valores = linea.Split(',');
                    //crear nuestro nuevo Producto
                    Producto producto = new Producto(int.Parse(valores[0]), valores[1], double.Parse(valores[2]));
                    //lo agregamos a la lista de productos
                    productos.Add(producto);
                }
            }
        }

        public Producto Buscar(int codigo)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                if (prod.GetCodigo() == codigo)
                    return prod;
            }
            return null;
        }

        public bool Eliminar(int codigo)
        {
            //buscar el producto
            for (int i = 0; i < productos.Count; i++)
            {
                //recupero el producto de la iteracion
                Producto prod = productos.ElementAt(i);
                if (prod.GetCodigo() == codigo) {
                    //elimino el producto en el indice que está
                    productos.RemoveAt(i);
                    //actualizo el archivo
                    GuardarArchivo();
                    return true;
                }
            }
            //retorna false indicando que no se borro
            return false;
        }

        public bool ActualizarProducto(Producto producto)
        {
            //buscar el producto
            for (int i = 0; i < productos.Count; i++)
            {
                //recupero el producto de la iteracion
                Producto prod = productos.ElementAt(i);
                if (prod.GetCodigo() == producto.GetCodigo())
                {
                    //actualizo el producto en el indice que está
                    productos[i] = producto;
                    //actualizo el archivo
                    GuardarArchivo();
                    return true;
                }
            }
            //retorna false indicando que no se borro
            return false;
        }

        //metodos publics
        public string GetProductos()
        {
            string mensaje = "";
            for (int i = 0; i < productos.Count; i++)
            {
                //recupero el producto de la iteracion
                Producto prod = productos.ElementAt(i);
                mensaje += $"{prod.GetCodigo()} \t\t {prod.GetDescripcion()} \t\t {prod.GetPrecio()}";
                mensaje += Environment.NewLine;
            }
            return mensaje;
        }

        public bool AgregarProducto(Producto item)
        {
            productos.Add(item);
            GuardarArchivo();
            return true;
        }

        private void GuardarArchivo()
        {
            string texto = "";
            //iterar o recorrer nuestra coleccion
            foreach (Producto producto in productos)
            {
                texto += $"{producto.GetCodigo()},{producto.GetDescripcion()},{producto.GetPrecio()};";
            }
            manejadorDeArchivos.GuardarArchivo(ARCHIVO_PRODUCTOS, texto);
        }
    }
}
