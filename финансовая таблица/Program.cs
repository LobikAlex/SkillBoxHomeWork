using System;

namespace финансовая_таблица
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] array = new int[12, 4];

            int[] profitNegative = new int[12];

            int profitPositive = 0;

            string months = "";

            Console.WriteLine($"{"Номер",5} {"Доход, руб.",15} {"Расход, руб.",15} {"Прибыль, руб.",15}");
            for (int i = 0; i < 12; i++)
            {
                array[i, 0] = i + 1;
                array[i, 1] = random.Next(5, 16) * 10000;
                array[i, 2] = random.Next(5, 16) * 10000;
                array[i, 3] = array[i, 1] - array[i, 2];
                profitNegative[i] = array[i, 3];
                Console.WriteLine($"{array[i, 0],5} {array[i, 1],15} {array[i, 2],15} {array[i, 3],15}");
            }

            profitNegative = profitNegative.Distinct().ToArray();
            Array.Sort(profitNegative);

            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    if (array[i, 3] > 0 && j == 0)
                    {
                        profitPositive++;
                    }
                    if (array[i, 3] == profitNegative[j])
                    {
                        if (String.IsNullOrWhiteSpace(months))
                        {
                            months = (i + 1).ToString();
                        }
                        else
                        {
                            months = months + ", " + (i + 1).ToString();
                        }
                    }
                }
            }

            Console.WriteLine("");

            Console.WriteLine($"Худшая прибыль в месяцах: {months}");
            Console.WriteLine($"Месяцев с положительной прибылью: {profitPositive}");

            Console.ReadKey();
           
        }
    }
}
