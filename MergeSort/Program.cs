using System;
using System.Linq;

public class Program
{
    public static void Main (string[] args)
    {
        int[] miArreglo = [41, 32, 39, 33, 45, 11, 50, 81, 58, 86, 43, 28, 64, 68, 31, 74, 62, 18, 5, 83, 24, 1, 78, 47, 77, 71, 39, 76, 86, 62, 93, 47, 61, 96, 26, 89, 43, 50, 25, 9, 69, 60, 72, 91, 28, 4, 7, 88, 100, 39];

        int[] arregloOrdenado = OrdenamientoMergeSort(miArreglo);

        Console.WriteLine("Arreglo Ordenado (Merge Sort): ");

        foreach (int numero in arregloOrdenado)
        {
            Console.WriteLine(numero + " ");
        }

        Console.ReadKey();
    }

    public static int[] OrdenamientoMergeSort(int[] arr)
    {
        MergeSortHelper (arr, 0, arr.Length - 1);

        return arr;
    }

    private static void MergeSortHelper(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = left + (right - left) / 2;

            MergeSortHelper(arr, left, middle);

            MergeSortHelper(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    private static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] L = new int[n1];
        int[] R = new int[n2];

        for (int i = 0; i < n1; ++i)
            L[i] = arr[left + i];
        for (int j = 0; j < n2; ++j)
            R[j] = arr[middle + 1 + j];

        int i_izq = 0, j_der = 0;
        int k_arr = left;

        while (i_izq < n1 && j_der < n2)
        {
            if (L[i_izq] <= R[j_der])
            {
                arr[k_arr] = L[i_izq];
                i_izq++;
            }
            else
            {
                arr[k_arr] = R[j_der];
                j_der++;
            }
            k_arr++;
        }

        while (j_der < n2)
        {
            arr[k_arr] = R[j_der];
            j_der++;
            k_arr++;
        }

        while (i_izq < n1)
        {
            arr[k_arr] = L[i_izq];
            i_izq++;
            k_arr++;
        }
    }
}