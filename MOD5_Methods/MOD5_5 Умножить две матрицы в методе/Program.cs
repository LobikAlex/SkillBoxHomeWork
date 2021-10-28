using System;

namespace MatrixХMatrix
{
    class Program
    {

        static int[,] Multy(int str, int str2, int column2, int[,] A, int[,] B)
        {
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
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Умножение матриц через метод");

            Console.Write("Введите количество строк матрицы 1: ");
            int str = int.Parse(Console.ReadLine());
            Console.Write("Введите количество Столбцов матрицы 1: ");
            int column = int.Parse(Console.ReadLine());
            Console.WriteLine("количество строк матрицы 2 = " + column);
            int str2 = column;
            Console.Write("ведите количество столбцов матрицы 2: ");
            int column2 = int.Parse(Console.ReadLine());

            //Создаём матрицы
            int[,] MATRIX1 = new int[str, column];
            int[,] MATRIX2 = new int[str2, column2];
            int[,] MATRIX3 = new int[str, column2];

            Random RND = new Random();

            // Заполняем первую матрицу
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    MATRIX1[i, j] = RND.Next(1, 6);
                    Console.Write($"{MATRIX1[i, j]}  ");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("\n\n\n");

            //Заполняем вторую матрицу
            for (int i = 0; i < str2; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    MATRIX2[i, j] = RND.Next(1, 5);
                    Console.Write($"{MATRIX2[i, j]}  ");
                }
                Console.WriteLine("\n");
            }


            MATRIX3 = Multy(str, str2, column2, MATRIX1, MATRIX2);                      // Вызываем метод умножения.  Результат в MATRIX3
 

      //Вывод
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
    }
}