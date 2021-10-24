using System;

namespace MOD4_Z1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Учёт финансов");

            //объявляем массивы для кредита, дебета и выручки
            int[] credit = new int[12];
            int[] debet = new int[12];
            int[] sum = new int[12];
            int plus = 0;
            Random RND = new Random();

            Console.WriteLine("месяц\tКредит\tДебет\tВыручка");
           

            //заполняем массивы
            for (int i = 0; i < 12; i++)
            {
                credit[i] = RND.Next(30, 100) * 10;
                debet[i] = RND.Next(10, 70) * 10;
                sum[i] = credit[i] - debet[i];
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",i, credit[i], debet[i], sum[i]);
                
                
                //вычисляем количество месяцев с положительным балансом
                if (sum[i] > 0)
                {
                  plus = ++plus;
                }
                
            }
            Console.WriteLine("Количество положительных месяцев: " + plus);
            Array.Sort(sum);
            foreach (var i in sum)
            {
                Console.WriteLine($"{i}\t");
            }

            Console.ReadKey();
        }
    }
}
// НЕ решена задача вывода худших месяцев:                  Худшая прибыль в месяцах: 7, 4, 1, 5, 12