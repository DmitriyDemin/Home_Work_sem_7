// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке 
// от M до N. Использовать рекурсию, не использовать циклы.
using System;
namespace Recursion
{
    class Task1
    {
        public static void Main()
        {
            void OutputOfNumbers(int first, int last)
            {
                Console.Write($"{first + 1}  ");
                if (first == last - 2)
                    Console.WriteLine();
                else OutputOfNumbers(first + 1, last);
                /* сведений о конктретном типе числового промежутка в условиях задачи нет, выводятся числа не 
                включая границ промежутка*/
            }
            Console.Clear();
            Console.Write("Введите значение начала диапазона натуральных чисел:  ");
            int M = int.Parse(Console.ReadLine()!);
            Console.Write("Введите значение окончания диапазона натуральных чисел:  ");
            int N = int.Parse(Console.ReadLine()!);
            if (M > N) /*на случай ошибки ввода*/
            {
                int temp = M;
                M = N;
                N = temp;
            }
            if (M == N || ((M + 1) == N))
            {
                Console.Write("в заданном диапазоне натуральных чисел нет");/*на случай ошибки ввода*/
                return;
            }
            else
                Console.Write("натуральные числа в заданном диапазоне:  ");
            OutputOfNumbers(M, N);
        }
    }
}

