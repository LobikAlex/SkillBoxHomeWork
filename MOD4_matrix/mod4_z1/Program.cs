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
            int[] month = new int[12];      // массив с месяцами
            int plus = 0;
            Random RND = new Random();

            Console.WriteLine("месяц\tКредит\tДебет\tВыручка");
           

            //заполняем массивы
            for (int i = 0; i < 12; i++)
            {
                month[i] = i+1;
                credit[i] = RND.Next(30, 100) * 10;
                debet[i] = RND.Next(10, 70) * 10;
                sum[i] = credit[i] - debet[i];
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",i+1, credit[i], debet[i], sum[i]);              
              
                //вычисляем количество месяцев с положительным балансом
                if (sum[i] > 0)
                {
                  plus = ++plus;
                }                
            }
            Console.WriteLine("Количество положительных месяцев: " + plus);



            //
            Array.Sort(sum, month);
            
            
            Console.WriteLine("Худшие месяцы:");


            int k = 0;
            int m = 3;
            
            // вычисляем 3 худшие месяца по условию задачи
            while (k < m)
            {
            Console.WriteLine($"{month[k]} месяц. Выручка: {sum[k]}");
            k++;
            
                if (sum[k] == sum[k-1])              // если выручка по месяцам одинаковая, то 
                {
                m++;                                 // отодвигием счетчик
                }               
            }

            Console.ReadKey();
        }
    }
}
