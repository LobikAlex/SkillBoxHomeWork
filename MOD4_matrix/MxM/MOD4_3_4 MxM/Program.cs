using System;

namespace MatrixХMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Умножение квадратных матриц");

            /// Задание не доделано.
            /// Работает только при условии квадратных матриц.

            /// Матрицу P можно умножить на матрицу K только в том случае,
            /// если число столбцов матрицы P равняется числу строк матрицы K.
            /// Матрицы, для которых данное условие не выполняется, умножать нельзя



            Console.Write("Введите количество строк матрицы 1: ");
            int str = int.Parse(Console.ReadLine());
            Console.Write("Введите количество Столбцов матрицы 1: ");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("количество строк матрицы 2 = " + column);
            Console.Write("ведите количество столбцов матрицы 2: ");
            int column2 = int.Parse(Console.ReadLine());

            //Создаём матрицы
            int[,] MATRIX1 = new int[str, column];
            int[,] MATRIX2 = new int[column, str];
            int[,] MATRIX3 = new int[str, str];

            Random RND = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    MATRIX1[i, j] = RND.Next(1, 6);
                    MATRIX2[j, i] = RND.Next(1, 5);
                }
                Console.WriteLine("\n");
            }


            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < column2; j++)
                {

                    MATRIX2[i, j] = RND.Next(1, 5);
                }
                Console.WriteLine("\n");
            }






            int s = 0;

            for (int k = 0; k < str; k++)
            {
                for (int i = 0; i < column2; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        s = s + MATRIX1[i, j] * MATRIX2[j, k];
                        //                        Console.WriteLine("s= s + " + MATRIX1[i, j] + " * " + MATRIX2[j, k]);
                    }
                    MATRIX3[k, i] = s;
                    //                    Console.Write("  " + s);
                    s = 0;
                    //                    Console.WriteLine("\n\n\n");

                }


            }



            //Вывод
            for (int i = 0; i < str; i++)
            {
                Console.Write("   |");
                // выводим матрицу
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,3} ", MATRIX1[i, j]));
                }

                // Выводим знак умножить
                if (i == str / 2)
                {
                    Console.Write("| х |");
                }
                else
                {
                    Console.Write("|   |");
                }


                // выводим вторую матрицу
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,3} ", MATRIX2[i, j]));
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


                // выводим Результирующую матрицу

                for (int j = 0; j < str; j++)
                {

                    Console.Write(String.Format("{0,4}", MATRIX3[i, j]));
                }
                Console.WriteLine("|");
            }
        }
    }
}
// *** Задание 3.3
// Заказчику требуется приложение позволяющщее перемножать математические матрицы
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)
// Справка https://ru.wikipedia.org/wiki/Матрица_(математика)#Умножение_матриц
// Добавить возможность ввода количество строк и столцов матрицы.
// Матрицы заполняются автоматически
// Если по введённым пользователем данным действие произвести нельзя - сообщить об этом
//  
//  |  1  3  5  |   |  1  3  4  |   | 22  48  57  |
//  |  4  5  7  | х |  2  5  6  | = | 35  79  95  |
//  |  5  3  1  |   |  3  6  7  |   | 14  36  45  |
//
//  
//                  | 4 |   
//  |  1  2  3  | х | 5 | = | 32 |
//                  | 6 |  
//