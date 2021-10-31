using System;

namespace Matrix_Х
{
    class Program
    {
        // Метод валидации чисел типа Byte
        static byte InputByte()
        {
            byte n;
            while (!byte.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Введите положительное целое число");
            }
            return n;
        }


        // Метод валидации чисел типа INT
        static int InputInt()
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Ошибка ввода! Введите целое число");
            }
            return n;
        }



        // Метод заполняющий матрицу
        static int[,] InputMatrix(int str, int column)
        {
            int[,] MATRIX = new int[str, column];
            Random RND = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    MATRIX[i, j] = RND.Next(10);
                }
            }
            return MATRIX;
        }
        
// Метод умножающий матрицу на число
        static int[,] MatrixNumber(int n, int[,] Mat)
        {
            int str = Mat.GetLength(0);
            int column = Mat.GetLength(1);

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

// Метод выводящий матрицу
        static void PrintMatrix(int n, int [,] MATRIX, int [,] Result)
        {
            int str = MATRIX.GetLength(0);
            int column = MATRIX.GetLength(1);


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

        static void Main(string[] args)
        {
            Console.WriteLine("Умножение матрицы на число через метод");

            // Для ввода 
            Console.Write("Введите число: ");
            int n = InputInt();
            Console.Write("Введите количество строк матрицы: ");
            int str = InputByte();
            Console.Write("Введите количество Столбцов матрицы: ");
            int column = InputByte();



            // ВЫзываем метод заполняющий матрицу
            int [,] MATRIX = InputMatrix(str, column);
    
// Вызов метода умножающий матрицу на число
            int [,] Result = MatrixNumber(n, MATRIX);

// Вызов метода выводящего матрицу
            PrintMatrix(n, MATRIX, Result);
 
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
