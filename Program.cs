using System;

namespace DelegatesDemo
{
    class Program4
    {
        static void Main()
        {
            int[] numbers = new int[20];
            for (int i = 0; i < 20; i++) numbers[i] = i + 1;

            Func<int, int> square = n => n * n;
            Func<int, int> times2 = n => n * 2;
            Func<int, int> minus5 = n => n - 5;

            int[] squared = Apply(numbers, square);
            int[] doubled = Apply(numbers, times2);
            int[] subtracted = Apply(numbers, minus5);

            Print("Squared", squared);
            Print("Times2", doubled);
            Print("Minus5", subtracted);
        }

        static int[] Apply(int[] arr, Func<int, int> func)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = func(arr[i]);
            }
            return result;
        }

        static void Print(string title, int[] arr)
        {
            Console.Write(title + ": ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
    }
}