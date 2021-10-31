using System;

namespace MOD5_8_Прогрессии
{
    class Program
    {
        // Метод Ввод n чисел в вектор
        static double[] InputArr(int n)
        {
            double[] Arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + ". ");

                while (!double.TryParse(Console.ReadLine(), out Arr[i]))                    // Блок валидации целых чисел
                {
                    Console.WriteLine("Ошибка ввода! Введите целое число");
                    Console.Write(i + 1 + ". ");
                }
            }
            return Arr;
        }

        //метод Тест на прогресию
        static void Progressia(double[] A)
        {
            int m = A.GetLength(0);  //получаем длину вектора
            int countA = 0;       //тут храним верность условий арифметики 
            int countG = 0;       //тут храним верность условий геометрии

            for (int i = 1; i < m - 1; i++)       
            {
                double min = A[i - 1];
                double n = A[i];
                double max = A[i + 1];

                if (n == (max + min) / 2)    // делаем сравнения 3-х соcедних чисел на прогрессию n-2 раза
                {
                    countA++;
                }

                if (Math.Abs(n) == Math.Sqrt(max * min))
                {
                    countG++;
                }    
         
            }
            if (countA == m - 2)
            {
                Console.WriteLine("Это арифметическая прогрессия");
            }
            if (countG == m - 2)
            {
                Console.WriteLine("Это геометрическая прогрессия");
            }
        }


        static void Main(string[] args)
        {

            Console.WriteLine("Сколько чисел будем вводить для определения прогрессии? минимум - 3");
            int n = Convert.ToInt32(Console.ReadLine());

            
            double[] Arr = InputArr(n);              //ввод чисел в вектор

            
            Array.Sort(Arr);                     //Сортируем вектор


            Progressia(Arr);               //отправляем вектор на проверку прогрессий

        }
    }
}
