using ProgramaArray2.Clases.PrimerMatriz;
using ProgramaArray2.Clases.SegundaMatriz;
using System;

namespace ProgramaArray2.Clases
{
    /// <summary>
    /// Clase que proporciona métodos para comparar dos matrices bidimensionales.
    /// </summary>
    public class ComparacionMatrices
    {
        /// <summary>
        /// Compara dos matrices bidimensionales para determinar si son iguales en contenido y dimensiones.
        /// </summary>
        /// <param name="PrimerMatriz">La primera matriz a comparar.</param>
        /// <param name="SegundaMatriz">La segunda matriz a comparar.</param>
        public void Comparacion(int[,] PrimerMatriz, int[,] SegundaMatriz)
        {
            // Verifica si las matrices tienen las mismas dimensiones
            if (PrimerMatriz.GetLength(0) == SegundaMatriz.GetLength(0) &&
                PrimerMatriz.GetLength(1) == SegundaMatriz.GetLength(1))
            {
                bool sonIguales = true; // Bandera para verificar si las matrices son iguales

                // Recorre las matrices y compara cada elemento
                for (int i = 0; i < PrimerMatriz.GetLength(0); i++)
                {
                    for (int j = 0; j < PrimerMatriz.GetLength(1); j++)
                    {
                        // Si algún elemento es diferente, las matrices no son iguales
                        if (PrimerMatriz[i, j] != SegundaMatriz[i, j])
                        {
                            sonIguales = false;
                            break; // Sale del bucle de columnas si hay una diferencia
                        }
                    }
                    if (!sonIguales) break; // Sale del bucle de filas si hay una diferencia
                }

                // Imprime el resultado de la comparación
                if (sonIguales)
                {
                    Console.WriteLine("Las matrices son iguales.");
                }
                else
                {
                    Console.WriteLine("Las matrices no son iguales.");
                }
            }
            else
            {
                Console.WriteLine("Las matrices tienen diferentes dimensiones.");
            }
        }
    }
}
