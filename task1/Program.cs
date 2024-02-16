// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.
using System;
namespace Recursion
{
    class Task1
    {
        public static void Main()
        {
            
            void OutputOfNumbers(int M, int N)
            {
                Console.Write($"{M+1}  "); 
                if (M == N-2)
                Console.WriteLine();
                else OutputOfNumbers(M+1, N);  
                // Console.Write($"{M+1}  ");         
            }

            Console.Clear();
            Console.Write("Введите значение начала диапазона натуральных чисел:  ");
            int M = int.Parse(Console.ReadLine()!);
            Console.Write("Введите значение окончания диапазона натуральных чисел:  ");
            int N = int.Parse(Console.ReadLine()!);
            Console.Write("натуральные числа в заданном диапазоне:  ");
            OutputOfNumbers(M,N);
        }
    }
}

// string printNumbers(int n){
//     if (n == 1)
//         return "1 ";
//     return printNumbers(n - 1) + $"{n} ";
// }
// /* f = printNumbers
// f(5) -> f(4) + "5 " = "1 2 3 4 5 "
//         |
//         f(3) + "4 "
//         |
//         f(2) + "3 "
//         |
//         f(1) + "2 "
//         |
//         "1 "