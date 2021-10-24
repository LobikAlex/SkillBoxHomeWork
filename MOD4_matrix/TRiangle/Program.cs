using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник Паскаля");
            Console.Write("Введите n: ");               // Приглашение ко вводу числа
            int n = int.Parse(Console.ReadLine());      // Ввод числа с клавиатуры

            int[,] pascal = new int[n, n];

            pascal[0, 0] = 1;
            for (int i = 1; i < n; i++)
            {
               //добавляем табы
               for (int k = 0; k < (n-i); k++)   
                {
                    Console.Write("\t");
                }

               //Заполняем треугольник
                for (int j = 1; j < n; j++)
                {
                    if (i < j)  {break;}
                    pascal[i, j] = pascal[i - 1, j] + pascal[i - 1, j - 1];
                    Console.Write($"{pascal[i, j]}\t\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadKey();
        }
    }
}