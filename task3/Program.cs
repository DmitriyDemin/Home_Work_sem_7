// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию,
// не использовать циклы.
using System;
namespace Recursion
{
    class Task3
    {
        public static void Main()
        {
            void OutputArray(int[] N, int i)
            {
                Console.Write($"{N[i]} \t");
                if (i == 0)
                {
                    Console.WriteLine();
                }
                else OutputArray(N, i - 1);
            }
            Console.Clear();
            Console.WriteLine("введите количество элементов массива:  ");
            int n = int.Parse(Console.ReadLine()!);
            int[] numbers = new int[n];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = new Random().Next(-10, 11);
            Console.WriteLine("Вывод элементов массива циклом для проверки:  ");
            for (int j = 0; j < numbers.Length; j++)
                Console.Write($"{numbers[j]}  \t");
            Console.WriteLine();
            Console.WriteLine("Вывод элементов массива рекурсией, начиная с конца:  ");
            OutputArray(numbers, (numbers.Length - 1));

        }

    }
}

