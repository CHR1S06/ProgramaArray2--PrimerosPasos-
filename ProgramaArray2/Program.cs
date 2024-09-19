using ProgramaArray2.Clases.PrimerMatriz;
using ProgramaArray2.Clases.SegundaMatriz;
using ProgramaArray2.Clases;
using System;

namespace ProgramaArray2
{
    internal class Program
    {
        /// <summary>
        /// Método principal que ejecuta el programa.
        /// </summary>
        /// <param name="args">Argumentos de la línea de comandos (no utilizados en este programa).</param>
        static void Main(string[] args)
        {
            // Crear una instancia de Matriz1 y llenar la primera matriz
            Matriz1 matriz1 = new Matriz1();
            matriz1.ProgramMatriz1();

            // Pausa para que el usuario pueda ver los resultados antes de continuar
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Para continuar con la segunda matriz por favor presione cualquier tecla.");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            // Crear una instancia de Matriz2 y llenar la segunda matriz
            Matriz2 matriz2 = new Matriz2();
            matriz2.ProgramMatriz2();

            // Pausa para que el usuario pueda ver los resultados antes de continuar
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            // Crear una instancia de ComparacionMatrices y comparar las dos matrices llenas
            ComparacionMatrices comparacionMatrices = new ComparacionMatrices();
            comparacionMatrices.Comparacion(matriz1.matrizm1, matriz2.matrizm2);
        }
    }
}

