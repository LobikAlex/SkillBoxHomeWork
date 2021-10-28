using System;

namespace Matrix_Х
{
    class Program
    {
        // Метод умножающий матрицу на число
        static int[,] MatrixNumber(int n, int[,] Mat, int str, int column)
        {
            int[,] Array = new int[str, column];
            
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Array[i, j] = Mat[i, j] * n;
                }
            }
            return Array;
        }
        
 
        static void Main(string[] args)
        {
            Console.WriteLine("Умножение матрицы на число через метод");

            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            int str = 0;
            int column = 0;

            do
            {
                Console.Write("Введите количество строк матрицы: ");
                str = int.Parse(Console.ReadLine());
                Console.Write("Введите количество Столбцов матрицы: ");
                column = int.Parse(Console.ReadLine());
                if (str <= 0 | column <= 0)
                {
                    Console.WriteLine("Количество строк и столбцов матрицы должно быть положительным");
                }
            } while (str <= 0 | column <= 0);

            //Создаём матрицу
            int[,] MATRIX = new int[str, column];
            Random RND = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    MATRIX[i, j] = RND.Next(10);
                }
                Console.WriteLine("\n");
            }

            

            // Вызов метода
            int [,] Result = MatrixNumber(n, MATRIX, str, column);




            for (int i = 0; i < str; i++)
            {
                // сначала выводим число со знаком умножения
                if (i == str / 2)
                {
                    Console.Write(String.Format($"{n,2} х |"));
                }
                else
                {
                    Console.Write("     |");
                }

                // выводим матрицу
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,3} ", MATRIX[i, j]));
                }

                // Выводим знак равно
                if (i == str / 2)
                {
                    Console.Write("| = |");
                }
                else
                {
                    Console.Write("|   |");
                }


                // выводим результирующую матрицу
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,3} ", Result[i, j]));
                }
                Console.WriteLine("|");
            }
        }  
    }
}



// * Задание 3.1
// Заказчику требуется приложение позволяющщее умножать математическую матрицу на число
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матрицы_на_число
// Добавить возможность ввода количество строк и столцов матрицы и число,
// на которое будет производиться умножение.
// Матрицы заполняются автоматически. 
// Если по введённым пользователем данным действие произвести невозможно - сообщить об этом
//
// Пример
//
//      |  1  3  5  |   |  5  15  25  |
//  5 х |  4  5  7  | = | 20  25  35  |
//      |  5  3  1  |   | 25  15   5  |
//
