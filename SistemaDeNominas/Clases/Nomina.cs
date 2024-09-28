using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeNominas.Clases
{
    public class Nomina
    {
        // Lista de empleados
        private List<Empleado> empleados;

        // Constructor que inicializa la lista de empleados
        public Nomina()
        {
            empleados = new List<Empleado>();
        }

        // Método para agregar un empleado a la nómina
        public void AgregarEmpleado(Empleado empleado)
        {
            empleados.Add(empleado);
        }

        // Método para mostrar el reporte de nómina
        public void MostrarReporte()
        {
            Console.WriteLine("=== Reporte de Nómina ===");

            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados registrados.");
                return;
            }

            foreach (Empleado emp in empleados)
            {
                Console.WriteLine($"Empleado: {emp.Nombre}");
                Console.WriteLine($"Salario por hora: {emp.SalarioPorHora:C}");
                Console.WriteLine($"Horas trabajadas: {emp.HorasTrabajadas}");
                Console.WriteLine($"Salario total: {emp.CalcularSalario():C}");
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
