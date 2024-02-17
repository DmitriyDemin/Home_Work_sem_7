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
                if (m == 0)
                {
                    return n + 1;
                    // }
                    // if else (m > 0 & n == 0){
                    //     Ackerman(m - 1, 1);
                    // }
                    // if else (m > 0 & n > 0){
                    //     Ackerman(m - 1, Ackerman(m - 1, 1));
                     }
                     return n;
            }
                    Console.WriteLine(Ackerman(0, 0));



                }

            }
        }
    
