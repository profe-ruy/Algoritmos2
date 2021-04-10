
namespace Semana10
{
    public class CursoMatematica
    {
        //propiedades encapsuladas
        private double Prueba1;
        private double Prueba2;
        private double Prueba3;
        private double Parcial;
        private double Final;

        public CursoMatematica(double prueba1, double prueba2, double prueba3, double parcial, double final)
        {
            Prueba1 = prueba1;
            Prueba2 = prueba2;
            Prueba3 = prueba3;
            Parcial = parcial;
            Final = final;
        }

        public double CalcularPromedio()
        {
            return 0.1 * Prueba1 + 0.1 * Prueba2 + 0.1 * Prueba3 + 0.2 * Parcial + 0.5 * Final;
        }
    }
}
