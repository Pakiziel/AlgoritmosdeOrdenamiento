using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] miArreglo = [41, 32, 39, 33, 45, 11, 50, 81, 58, 86, 43, 28, 64, 68, 31, 74, 62, 18, 5, 83, 24, 1, 78, 47, 77, 71, 39, 76, 86, 62, 93, 47, 61, 96, 26, 89, 43, 50, 25, 9, 69, 60, 72, 91, 28, 4, 7, 88, 100, 39];

        int[] arregloOrdenado = OrdenamientoInsercion(miArreglo);

        Console.WriteLine("Arreglo Ordenado (Inserción):  ");

        foreach (int numero in arregloOrdenado)
        {
            Console.WriteLine(numero + " ");
        }

        Console.ReadKey();
    }

    public static int[] OrdenamientoInsercion(int[] arr)
    {
        int n = arr.Length;


        for (int i = 1; i < n; i++)
        {
            int llave = arr[i];

            int j = i - 1;

            while (j >= 0 && arr[j] > llave)
            {
                arr[j + 1] = arr[j];

                j = j - 1;
            }

            arr[j + 1] = llave;
         
        }
        return arr;
    }
}