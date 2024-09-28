using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeNominas.Clases
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public double SalarioPorHora { get; set; }
        public double HorasTrabajadas { get; set; }

        // Método para calcular el salario total
        public double CalcularSalario()
        {
            return SalarioPorHora * HorasTrabajadas;
        }
    }
}
