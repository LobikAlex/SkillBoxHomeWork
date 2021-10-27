using System;

namespace Matrix_Х
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сложение и вычитание матриц");
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

            Console.WriteLine("\n\n");
            
            
            // Создаём две матрицы                                 
            int[,] MATRIX1 = new int[str, column];
            int[,] MATRIX2 = new int[str, column];
 
            
            // Заполняем обе матрицы
            Random RND = new Random();   
            for (int i = 0; i < str; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    MATRIX1[i, j] = RND.Next(10);                               
                    MATRIX2[i, j] = RND.Next(10);
                }
            }

            // теперь займемся выводом
            // два цикла. Первый на сложение, второй на вычитание
            for (int k = 0; k < 2; k++)                                                  
            {

             //В этом цикле строки
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
                        if (k==1)
                        {
                            Console.Write(" | - |");
                        }
                        else
                        {
                          Console.Write(" | + |");      
                        }                              

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
                    

             //между второй и третьей, либо знак равенства
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
                        if (k==0)
                        {
                         Console.Write(String.Format("{0,3}", MATRIX1[i, j]+MATRIX2[i,j]));
                        }
                        else
                        {
                            Console.Write(String.Format("{0,3}", MATRIX1[i, j] - MATRIX2[i, j]));
                        }
                    }
                    Console.Write(" |");
                    Console.WriteLine();

                }

                Console.WriteLine("\n\n\n\n\n");

            }

        }
    }
}