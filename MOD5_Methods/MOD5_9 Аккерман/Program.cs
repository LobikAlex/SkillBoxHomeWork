using System;

namespace MOD5_9_Аккерман
{
    class Program
    {
        static int Akker(int n, int m)
        {
         
            if (n == 0)
            {
                return m + 1;
            }
            else
            {
                if (m == 0)
                {
                    return Akker(n - 1, 1);
                }
                else
                {
                    return Akker(n - 1, Akker(n, m - 1));

                }
            }
          
        }


        static void Main(string[] args)
        {
            Console.Write("Введите 2 числа для функции Аккермана\n1: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("2: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine( Akker(n, m) ); 

        }
    }
}
// *Задание 5
// Вычислить, используя рекурсию, функцию Аккермана:
// A(2, 5), A(1, 2)
// A(n, m) = m + 1, если n = 0,
//         = A(n - 1, 1), если n <> 0, m = 0,
//         = A(n - 1, A(n, m - 1)), если n> 0, m > 0.
// 
// Весь код должен быть откоммментирован