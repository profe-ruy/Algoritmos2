using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana08
{
    public class RepositorioProducto
    {
        //CRUD : Create, Read, Update, Delete
        private List<Producto> productos = new List<Producto>();

        //Listar
        public List<Producto> GetProductos()
        {
            return productos;
        }

        //Obtener por ID
        public Producto GetProducto(int codigo)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                Producto prod = productos.ElementAt(i);
                if (prod.GetCodigo() == codigo)
                    return prod;
            }
            return null;
        }

        //Agregar producto
        public bool AddProducto(Producto prod)
        {
            try
            {
                productos.Add(prod);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Actualizar
        public bool UpdateProducto(Producto prod)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos[i].GetCodigo() == prod.GetCodigo())
                {
                    productos[i] = prod;
                    return true;
                }
            }
            return false;
        }

        //eliminar
        public bool DeleteProducto(int codigo)
        {
            for (int i = 0; i < productos.Count; i++)
            {
                if (productos.ElementAt(i).GetCodigo() == codigo)
                {
                    productos.RemoveAt(i);
                    return true;
                }
            }
            return false;
        }
    }
}
