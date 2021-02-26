using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana01_Ejercicio2
{
    public class Empleado
    {

        private int Codigo;
        private string Nombre;
        private int Horas;
        private double Tarifa;

        public Empleado(int codigo, string nombre, int horas, double tarifa)
        {
            if (string.IsNullOrEmpty(nombre))
                throw new ArgumentNullException("El nombre es requerido");
            Codigo = codigo;
            Nombre = nombre;
            Horas = horas;
            Tarifa = tarifa;
        }

        public int GetCodigo()
        {
            return Codigo;
        }

        public void SetCodigo(int codigo)
        {
            Codigo = codigo;
        }

        public int GetHoras()
        {
            return Horas;
        }

        public void SetHoras(int horas)
        {
            Horas = horas;
        }
        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string nombre)
        {
            Nombre = nombre;
        }

        public double GetTarifa()
        {
            return Tarifa;
        }

        public void SetTarifa(double tarifa)
        {
            Tarifa = tarifa;
        }

        public double GetSueldoBruto() {
            return Horas * Tarifa;
        }

        public double GetDescuento() {
            return 0.11 * GetSueldoBruto();
        }

        public double GetSueldoNeto() {
            return GetSueldoBruto() - GetDescuento();
        }
    }
}
