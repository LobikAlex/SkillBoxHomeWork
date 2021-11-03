using System;
using System.Text;
using System.IO;

namespace Хакатон
{
    class Program
    {
        static int InputInt()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) & n > 1_000_000_000)
            {
                Console.WriteLine("Ошибка ввода! Введите целое число не более миллиона");
            }
            return n;
        }


        static void Main(string[] args)
        {
            Console.Write("Хакатон. введите целое число до 1.000.000.000: ");
            int n = InputInt();

            int[] N = new int[n];
            for (int i = 1; i <=n; i++)
            {
                N[i] = n;
            }


            for (int i = 2; i <=n; i++)
            {
                for (int j = i+1; j <=n; j++)
                {
                    if ( N[j] % N[i] == 0 )
                    {

                    }
                }


            }








            //using (StreamWriter sw = new StreamWriter("n.txt", true, Encoding.Unicode))
            //{             
            //    for (int i = 2; i <= n; i++)
            //    {
            //
            //      if (N[i] =
            //        sw.WriteLine($"{i},");
                    
            //    }
            //}

            Console.ReadKey();

        }
    }
}
