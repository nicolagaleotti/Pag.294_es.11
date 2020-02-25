using System;
using Metodo;

namespace Esercizio11
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Console.WriteLine("Inserisci la lunghezza dell'array: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int numero;
            for (int i = 0; i < a.Length; i++)
            {
                numero = r.Next(1, 50);
                a[i] = numero;
            }
            Console.WriteLine("Array randomico:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            a = CountingSort.Sort(a);
            Console.WriteLine("\nArray ordinato:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine("\nLa complessità è n^2!");
            Console.ReadLine();
        }
    }
}
