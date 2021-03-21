namespace Semana06
{
    public class Producto
    {
        private int Codigo;
        private string Descripcion;
        private double Precio;

        public Producto(int codigo, string descripcion, double precio)
        {
            Codigo = codigo;
            Descripcion = descripcion;
            Precio = precio;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public string GetDescripcion()
        {
            return Descripcion;
        }
        public double GetPrecio()
        {
            return Precio;
        }

        public void SetCodigo(int codigo) {
            Codigo = codigo;
        }

        public void SetDescripcion(string descripcion) {
            Descripcion = descripcion;
        }

        public void SetPrecio(double precio) {
            Precio = precio;
        }
    }
}
