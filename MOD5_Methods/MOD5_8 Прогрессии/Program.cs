using System;

namespace MOD5_8_Прогрессии
{
    class Program
    {
        static void Arif(int min, int n, int max)
        {

            if (n == (max + min) / 2 & (max + min) % 2 == 0)
            {
                Console.WriteLine("Эти числа являются элементами арифметической прогрессии");
            }
            else 
            {
                Console.WriteLine("Эти числа НЕ являются элементами арифметической прогрессии");
            }
        }

        static void Geom(int min, int n, int max)
        {

            if (Math.Abs(n) == Math.Sqrt(max * min) )
            {
                Console.WriteLine("Эти числа являются элементами геометрической прогрессии");
            }
            else
            {
                Console.WriteLine("Эти числа НЕ являются элементами геометрической прогрессии");
            }
        }






        static void Main(string[] args)
        {
            Console.Write("Нужно ввести 3 числа.\n1. ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. ");
            int c = Convert.ToInt32(Console.ReadLine());
            int max, min, n;


            // Находим мин и макс из чисел
            max = a>b ? a : b;
            max = max > c ? max : c;

            min = a > b ? b : a;
            min = min < c ? min : c;

            // Находим среднее число
            if (a != min & a != max)
            {
                n = a;
            }
            else
            {
                if (b!=min & b!= max)
                {
                    n = b;
                }
                else
                {
                    n = c;
                }
            }
            
            Arif(min, n, max);
            Geom(min, n, max);
        }
    }
}
