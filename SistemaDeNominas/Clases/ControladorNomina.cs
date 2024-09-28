using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaDeNominas.Clases
{
    public class ControladorNomina
    {
        private Nomina nomina;

        // Constructor que inicializa la nómina
        public ControladorNomina()
        {
            nomina = new Nomina();
        }

        // Método para iniciar el proceso de la nómina
        public void Iniciar()
        {
            bool continuar = true;

            while (continuar)
            {
                try
                {
                    Console.WriteLine("=== Sistema de Nómina ===");

                    // Solicitar información del empleado
                    string nombre = SolicitarNombre();
                    double salarioPorHora = SolicitarDouble("Ingrese el salario por hora del empleado: ");
                    double horasTrabajadas = SolicitarDouble("Ingrese las horas trabajadas del empleado: ");

                    // Crear un nuevo empleado
                    Empleado empleado = new Empleado
                    {
                        Nombre = nombre,
                        SalarioPorHora = salarioPorHora,
                        HorasTrabajadas = horasTrabajadas
                    };

                    // Agregar el empleado a la nómina
                    nomina.AgregarEmpleado(empleado);

                    // Preguntar si se quiere agregar otro empleado
                    Console.Write("¿Desea agregar otro empleado? (s/n): ");
                    continuar = Console.ReadLine().ToLower() == "s";
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.Clear(); // Limpiar la pantalla después de cada operación
            }

            // Mostrar el reporte final de la nómina
            nomina.MostrarReporte();
        }

        // Método para solicitar el nombre del empleado
        private string SolicitarNombre()
        {
            while (true)
            {
                Console.Write("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine();

                // Validar que el nombre no esté vacío
                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    return nombre;
                }
                else
                {
                    Console.WriteLine("El nombre no puede estar vacío. Intente de nuevo.");
                }
            }
        }

        // Método para solicitar y validar un número decimal
        private double SolicitarDouble(string mensaje)
        {
            while (true)
            {
                try
                {
                    Console.Write(mensaje);
                    double valor = Convert.ToDouble(Console.ReadLine());

                    // Validar que el valor sea positivo
                    if (valor < 0)
                    {
                        throw new ArgumentException("El valor no puede ser negativo.");
                    }

                    return valor;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
