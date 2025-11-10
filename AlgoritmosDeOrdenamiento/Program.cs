/* Recorrer un conjunto de datos comparando pares de elementos. Si el
primero es mayor al segundo, invertir sus lugares. Repetir el procedimiento
hasta recorrer todo el conjunto */

using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] miArreglo = [41, 32, 39, 33, 45, 11, 50, 81, 58, 86, 43, 28, 64, 68, 31, 74, 62, 18, 5, 83, 24, 1, 78, 47, 77, 71, 39, 76, 86, 62, 93, 47, 61, 96, 26, 89, 43, 50, 25, 9, 69, 60, 72, 91, 28, 4, 7, 88, 100, 39];

        int[] arregloOrdenado = OrdenamientoBurbuja(miArreglo);

        Console.WriteLine("Arreglo Ordenado: ");

        foreach (int numero in arregloOrdenado)
        {
            Console.WriteLine(numero + " ");
        }
      
        Console.ReadKey();
    }

    public static int[] OrdenamientoBurbuja(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i ; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];

                    arr[j] = arr[j + 1];

                    arr[j + 1] = temp;
                }
            }
        }
        return arr;
    }
}