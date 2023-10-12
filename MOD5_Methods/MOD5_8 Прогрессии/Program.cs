using System;

namespace MOD5_8_Прогрессии
{
    class Program
    {

        /// <summary>
        /// Ввод и валидация числа типа Byte
        /// </summary>
        static byte InputByte()
        {
            byte n;
            while (!byte.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Введите положительное целое число");
            }
            return n;
        }


        /// <summary>
        /// Ввод n чисел в вектор
        /// </summary>

        static double[] InputArr(int n)
        {
            double[] Arr = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write(i + 1 + ". ");

                while (!double.TryParse(Console.ReadLine(), out Arr[i]))        // Блок валидации целых чисел
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

                if (Math.Abs(n) == Math.Sqrt(max * min) & n !=0)
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
            if (countA != m - 2 & countG != m - 2)
            {
                Console.WriteLine("Прогрессий нет");
            }


        }


        static void Main(string[] args)
        {

            Console.WriteLine("Сколько чисел будем вводить для определения прогрессии? минимум - 3");

            int n = InputByte();                     // отправляем на валидацию ввода
                        
            double[] Arr = InputArr(n);              // ввод чисел в вектор

            
            Array.Sort(Arr);                     // Сортируем вектор


            Progressia(Arr);               // отправляем вектор на проверку прогрессий
            Console.ReadKey();

        }
    }
}





// Задание 4. Написать метод принимающий некоторое количесво чисел, выяснить
// является заданная последовательность элементами арифметической или геометрической прогрессии
// 
// Примечание
//             http://ru.wikipedia.org/wiki/Арифметическая_прогрессия
//             http://ru.wikipedia.org/wiki/Геометрическая_прогрессия