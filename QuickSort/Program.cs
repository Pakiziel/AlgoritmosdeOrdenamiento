using System;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        int[] miArreglo = [41, 32, 39, 33, 45, 11, 50, 81, 58, 86, 43, 28, 64, 68, 31, 74, 62, 18, 5, 83, 24, 1, 78, 47, 77, 71, 39, 76, 86, 62, 93, 47, 61, 96, 26, 89, 43, 50, 25, 9, 69, 60, 72, 91, 28, 4, 7, 88, 100, 39];

        int[] arregloOrdenado = OrdenamientoQuickSort(miArreglo);

        Console.WriteLine("Arreglo Ordenado (Quick Sort):   ");

        foreach (int numero in arregloOrdenado)
        {
            Console.WriteLine(numero + " ");
        }

        Console.ReadKey();
    }

    public static int[] OrdenamientoQuickSort(int[] arr)
    {
        QuickSortHelper (arr, 0, arr.Length - 1);

        return arr;
    }

    private static void QuickSortHelper(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pi = Particion(arr, low, high);

            QuickSortHelper(arr, low, pi - 1);

            QuickSortHelper(arr, pi + 1, high);


        }
    }

    public static void Swap(int a, int b)
    {
        int temp1 = arr[i];

    

    }

    private static int Particion (int[] arr, int low, int high)
    {
        int pivote = arr[high];

        int i = (low - 1);

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivote)
            {
                i++;

                int temp1 = arr[i];

                arr[i] = arr[j];

                arr[j] = temp1;
            }
        }

        int temp2 = arr[i + 1];

        arr[i + 1] = arr[high];

        arr[high] = temp2;

        return i + 1;
    }
}