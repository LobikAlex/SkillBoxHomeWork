using System;

namespace MatrixХMatrix
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


        //Метод заполняющий матрицу
        static int[,] InputMatrix(int str, int column)
        {
            int[,] A = new int[str, column];

            Random RND = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    A[i, j] = RND.Next(10);

                }
            }
            return A;
        }

       //Метод перемножающий матрицы
        static int[,] Multy(int[,] A, int[,] B)
        {
            //получаем значения строк и столбцов
            int str = A.GetLength(0);
            int str2 = B.GetLength(0);
            int column2 = B.GetLength(1);


            int[,] C = new int[str, column2];
          
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    C [i, j] = 0;
                    for (int k = 0; k < str2; k++)
                    {
                        C[i, j] = C[i, j] + A[i, k] * B[k, j];
                    }
                }
            }
            return C;
        }

        //Метод выводящий перемножающиеся матрицы
        static void PrintMulty(int[,] MATRIX1, int[,] MATRIX2, int[,] MATRIX3)
        {
            int str = MATRIX1.GetLength(0);
            int column = MATRIX1.GetLength(1);
            int str2 = MATRIX2.GetLength(0);
            int column2 = MATRIX2.GetLength(1);


            int str3 = Math.Max(str, str2);

            for (int i = 0; i < str3; i++)
            {
                if (i == 0)
                {
                    Console.Write("|");
                }
                else
                {
                    Console.Write(" ");
                }

                // выводим матрицу 1

                for (int j = 0; j < column; j++)
                {
                    if (i < str)
                    {


                        Console.Write(String.Format("{0,3} ", MATRIX1[i, j]));
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }

                // Выводим знак умножить
                if (i == str3 / 2)
                {
                    Console.Write("| х |");
                }
                else
                {
                    if (i >= str)
                    {
                        Console.Write("    |");
                    }
                    else
                    {
                        Console.Write("|   |");
                    }

                }


                // выводим вторую матрицу
                for (int j = 0; j < column2; j++)
                {
                    if (i < str2)
                    {
                        Console.Write(String.Format("{0,3} ", MATRIX2[i, j]));
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }

                // Выводим знак равно
                if (i == str3 / 2)
                {
                    Console.Write("| = |");
                }
                else
                {
                    Console.Write("|   |");
                }


                // выводим Результирующую матрицу

                for (int j = 0; j < column2; j++)
                {
                    if (i < str)
                    {
                        Console.Write(String.Format("{0,4}", MATRIX3[i, j]));
                    }
                    else
                    {
                        Console.Write("    ");
                    }
                }

                Console.WriteLine("|");


            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Умножение матриц через метод");
            int str, str2, column, column2;


                Console.Write("Введите количество строк матрицы 1: ");
                str = InputByte();
                Console.Write("Введите количество Столбцов матрицы 1: ");
                column = InputByte();
                Console.WriteLine("количество строк матрицы 2 = " + column);
                str2 = column;
                Console.Write("ведите количество столбцов матрицы 2: ");
                column2 = InputByte();
            
            
//Создаём матрицы через метод
            int[,] MATRIX1 = InputMatrix(str, column);
            int[,] MATRIX2 = InputMatrix(str2, column2);
            

// Получаем результирующую матрицу. Результат в MATRIX3
            int[,] MATRIX3 = Multy(MATRIX1, MATRIX2);


            //Вывод
            PrintMulty(MATRIX1, MATRIX2, MATRIX3);
        }
    }
}