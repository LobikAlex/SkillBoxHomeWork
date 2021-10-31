using System;

namespace MOD5_9_Аккерман
{
    class Program
    {

        // Метод валидации чисел типа Byte
        static byte InputInt()
        {
            byte n;
            while (!byte.TryParse(Console.ReadLine(), out n))                    
            {
                Console.WriteLine("Ошибка ввода! Введите положительное целое число");
            }
            return n;
        }


        //Метод вычисляющий функцию Аккермана
        static int Akker(int n, int m)
        {
         
            if (n == 0)                                     // проверка первого условия
            {
                return m + 1;
            }
            else
            {
                if (m == 0)                                   // проверка второго условия
                {
                    return Akker(n - 1, 1);
                }
                else
                {
                    return Akker(n - 1, Akker(n, m - 1));     // тут используем рекурсию

                }
            }
          
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите 2 целых числа для функции Аккермана: ");
            byte n, m;                                        // для этой функции удобен тип byte

            n = InputInt();   //Метод для введения целого числа
            m = InputInt();

            Console.WriteLine("Результат: " + Akker(n, m) );
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