using SistemaDeNominas.Clases;
using System;

namespace SistemaDeNominas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia del controlador y comenzar el sistema
            ControladorNomina controlador = new ControladorNomina();
            controlador.Iniciar();
        }
    }
}
