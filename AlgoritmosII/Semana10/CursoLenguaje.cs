namespace Semana10
{
    public class CursoLenguaje : CursoMatematica
    {
        // un constructor de hijo llamando a padre con parametros 
        public CursoLenguaje(double prueba1, double prueba2, double prueba3, double parcial, double final) 
                    : base(prueba1,prueba2,prueba3,parcial, final)
        {
            
        }

        //public CursoLenguaje(double prueba1, double prueba2, double prueba3, double parcial, double final)
        //{
        //    Prueba1 = prueba1;
        //    Prueba2 = prueba2;
        //    Prueba3 = prueba3;
        //    Parcial = parcial;
        //    Final = final;
        //}

        //public double CalcularPromedio()
        //{
        //    return 0.1 * Prueba1 + 0.1 * Prueba2 + 0.1 * Prueba3 + 0.2 * Parcial + 0.5 * Final;
        //}
    }
}
