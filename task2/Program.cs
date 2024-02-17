// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

using System;
namespace Recursion
{
    class Task2
    {
        public static void Main()
        {
            int Ackerman(int m, int n)
            {
                while (m != 0)
                {
                    if (m > 0 & n == 0)
                    {
                        return Ackerman(m - 1, 1);
                    }
                    else if (m > 0 & n > 0)
                        return Ackerman(m - 1, Ackerman(m, n-1));
                }
                return n + 1;
             }
            Console.Clear();
            Console.Write("Введите значение аргумента m:  ");
            int m = int.Parse(Console.ReadLine()!);
            Console.Write("Введите значение аргумента n:  ");
            int n = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Значение функции Аккермана для аргументов {m} и {n} равно {Ackerman(m, n)}");
        }

    }
}

