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

        //Метод заполняющий матрицу
        static int [,] InputMatrix(int str, int column)
        {
            int[,] A = new int[str, column];
            
            Random RND = new Random();
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    A [i, j] = RND.Next(10);
                   
                }
            }
            return A;
        }
       

        // Метод суммирующий две матрицы
        static int[,] SumMatrix(int [, ]A, int [,] B)
        {

            int str = A.GetLength(0);
            int column = A.GetLength(1);

            int[,] C = new int[str, column];
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
            return C;
        }

        // Метод выводящий сумму 2-х матриц
        static void PrintSumMatrix(int [,] MATRIX1, int[,] MATRIX2, int[,] SUM)
        {
            // теперь займемся выводом
            // два цикла. Первый на сложение, второй на вычитание
            int str = MATRIX1.GetLength(0);
            int column = MATRIX1.GetLength(1);


            for (int i = 0; i < str; i++)
            {
                Console.Write("|");


                //Выводим первую матрицу
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,3}", MATRIX1[i, j]));
                }


                // Между первой и второй промежуток небольшой, либо знак арифметической операции
                if (i == str / 2)
                {
                    Console.Write(" | + |");
                }
                else
                {
                    Console.Write(" |   |");
                }


                //выводим вторую матрицу
                for (int j = 0; j < column; j++)
                {
                    Console.Write(String.Format("{0,3} ", MATRIX2[i, j]));
                }


                if (i == str / 2)
                {
                    Console.Write("| = |");
                }
                else
                {
                    Console.Write("|   |");
                }


                //выводим третью матрицу
                for (int j = 0; j < column; j++)
                {

                    Console.Write(String.Format("{0,3}", SUM[i, j]));

                }
                Console.Write(" |");
                Console.WriteLine();

            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сложение и вычитание матриц");
            byte str = 0;
            byte column = 0;

                Console.Write("Введите количество строк матрицы: ");
                str = InputByte();
                Console.Write("Введите количество Столбцов матрицы: ");
                column = InputByte();


            Console.WriteLine("\n\n");


            // Создаём две матрицы                                 
            int[,] MATRIX1 = InputMatrix(str, column);
            int[,] MATRIX2 = InputMatrix(str, column);
            
            // Суммируем 2 матрицы
            int[,] SUM = SumMatrix(MATRIX1, MATRIX2);
            
            // Выводим в консоль матрицы и их сумму
            PrintSumMatrix(MATRIX1, MATRIX2, SUM);

                Console.WriteLine("\n\n\n\n\n");
        }
    }
}