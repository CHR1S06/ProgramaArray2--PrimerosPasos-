using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProgramaArray2.Clases.SegundaMatriz
{
    /// <summary>
    /// Clase que maneja una matriz bidimensional de enteros, permitiendo definir sus dimensiones,
    /// ingresar valores para cada elemento y mostrar estos valores en la consola.
    /// </summary>
    public class Matriz2
    {
        private int[,] matriz2; // Matriz bidimensional de enteros
        private int filasM2 = 0; // Número de filas de la matriz
        private int columnasM2 = 0; // Número de columnas de la matriz

        /// <summary>
        /// Método principal que gestiona la creación, llenado y visualización de la matriz.
        /// </summary>
        public void ProgramMatriz2()
        {
            Console.WriteLine("Por favor introduzca la longitud o dimensión de la matriz2:\n");

            // Solicita y valida el número de filas
            Console.Write("Por favor introduzca la cantidad de filas: ");
            while (true)
            {
                try
                {
                    filasM2 = Convert.ToInt16(Console.ReadLine());
                    if (filasM2 > 0)
                    {
                        break; // Salir del bucle si el valor es válido
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca un valor válido y dentro del rango.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de entrada: " + ex.Message);
                }
            }

            // Solicita y valida el número de columnas
            Console.Write("Por favor introduzca la cantidad de columnas: ");
            while (true)
            {
                try
                {
                    columnasM2 = Convert.ToInt16(Console.ReadLine());
                    if (columnasM2 > 0)
                    {
                        break; // Salir del bucle si el valor es válido
                    }
                    else
                    {
                        Console.WriteLine("Por favor introduzca un valor válido y dentro del rango.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error de entrada: " + ex.Message);
                }
            }

            // Inicializa la matriz con las dimensiones especificadas
            matriz2 = new int[filasM2, columnasM2];

            // Llenado de la matriz con valores proporcionados por el usuario
            for (int fila = 0; fila < filasM2; fila++)
            {
                for (int columna = 0; columna < columnasM2; columna++)
                {
                    Console.Write("Digite el valor del elemento: ");
                    int Elements;

                    while (true)
                    {
                        try
                        {
                            Elements = Convert.ToInt32(Console.ReadLine());
                            break; // Salir del bucle si el valor es válido
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error de entrada: " + ex.Message);
                        }
                    }
                    matriz2[fila, columna] = Elements; // Asigna el valor al elemento de la matriz
                }
            }

            // Pausa la ejecución durante 3 segundos para permitir al usuario ver los valores ingresados
            Thread.Sleep(3000);
            Console.Clear(); // Limpia la consola

            MostrarM2(); // Muestra los valores de la matriz
        }

        /// <summary>
        /// Muestra los valores de la matriz en la consola.
        /// </summary>
        public void MostrarM2()
        {
            Console.WriteLine("Valores de la matriz:");

            // Recorre y muestra cada elemento de la matriz
            for (int filaM = 0; filaM < filasM2; filaM++)
            {
                for (int columnaM = 0; columnaM < columnasM2; columnaM++)
                {
                    Console.Write(matriz2[filaM, columnaM] + "  "); // Imprime el valor del elemento
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }

        /// <summary>
        /// Propiedad que permite acceder a la matriz desde fuera de la clase.
        /// </summary>
        public int[,] matrizm2
        {
            get { return matriz2; }
        }
    }
}
