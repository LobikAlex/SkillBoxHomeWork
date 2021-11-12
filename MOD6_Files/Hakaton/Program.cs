using System;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Diagnostics;


namespace Хакатон
{
    class Program
    {
        /// <summary>
        /// метод ввода директории  и проверка существования
        /// </summary>
        /// <returns></returns>
        static string EnterDir(string FileName)
        {
            string dir;
            do
            {
                Console.WriteLine("Введите путь до файла с числом N");
                dir = Console.ReadLine();
                if (File.Exists(dir + FileName))
                {
                    Console.WriteLine("В Каталоге" + dir + " существует файл " + FileName);
                    continue;
                }
                else
                {
                    Console.WriteLine("Каталога с таким файлом не существует");
                }

            } while (!Directory.Exists(dir));
            return dir + FileName;
        }

        /// <summary>
        /// Возвращает существующий файл для чтения числа N
        /// </summary>
        /// <returns></returns>
        static string EnterFile()
        {

            Console.WriteLine("Введите имя файла с числом N");
            string FileName = Console.ReadLine();

            if (!File.Exists(FileName))
            {
                Console.WriteLine("Файл" + FileName + " в текущем каталоге не существует.");
                FileName = EnterDir(FileName);
            }

            return FileName;
        }

        /// <summary>
        /// Чтение числа N из файла и валидация.
        /// </summary>
        /// <param name="FileName"></param>
        /// <returns></returns>
        static int ReadN(string FileName)
        {
            int n;

            if (Int32.TryParse(File.ReadAllText(FileName), out n) & n > 0 & n <= 1_000_000)
            {
                Console.WriteLine("Данные из файла прочитаны, N = " + n);
            }
            else
            {
                Console.WriteLine("Данные в файле не корректны.");
            }
            return n;
        }


        /// <summary>
        /// Метод возвращает число групп с неделимыми числами
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        static int Chek(int n)
        {
            int i;
            double m = 0;
            for (i = 0; i < n / 2; i++)
            {
                m = Math.Pow(2, i);

                if (m > n)
                {
                    break;
                }
            }


            return i;
        }


        /// <summary>
        /// Режим работы 1. Вывод сообщения о количестве групп
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        static void Mode1(int n, int m)
        {
            Console.WriteLine("Для числа " + n + " существует не менее " + m + " групп с неделимыми числами");
        }


        /// <summary>
        /// Режим работы номер 2. ЗАпись групп в файл
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <param name="FileName"></param>
        static void Mode2(int n, int m, string FileName)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();                               // Засекаем время

            int[][] N = LineMethod(n, m);                   // метод вернет нам массив строк

            WriteFile(FileName, N);                 // Записываем массив строк в файл                              

            Console.WriteLine("Данные записаны в файл. Архивировать файл? y/n: ");

            if (char.ToLower(Console.ReadKey(true).KeyChar) == 'y')
            {
                ZIP(FileName);
                stopwatch.Stop();
                Console.WriteLine($"Задача выполнена за {stopwatch.ElapsedMilliseconds} миллисекунд");
            }
        }


        /// <summary>
        /// Метод запись в файл
        /// </summary>
        /// <param name="N"></param>
        static void WriteFile(string FileName, int[][] N)
        {

            using (StreamWriter sw = new StreamWriter(FileName, true, Encoding.Unicode))
            {
                for (int i = 0; i < N.Length; i++)
                {
                    sw.WriteLine();
                    for (int j = 0; j < N[i].Length; j++)
                    {
                        sw.Write(N[i][j] + " ");
                    }
                }
            }
            Console.WriteLine("запись произведена");
        }


        /// <summary>
        /// Метод возвращает массив строк с группами неделимых чисел
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int[][] LineMethod(int n, int m)
        {
            int[][] N = new int[m][];              // создаем массив из m строк

            int pow = 1;                             // степень двойки
                                                     //позиция во втором массиве
            for (int i = 0; i < m; i++)              // первый цикл по строкам
            {
                int k = 0;

                if (i == m - 1)                          // тут определяем длину каждой строки
                {
                    N[i] = new int[n - pow];             // в последней строке длина может быть короче
                }
                else
                {
                    N[i] = new int[pow * 2 - pow];      //стандартная длина
                }


                for (int j = pow; (j < pow * 2) & (j < n); j++)       // второй цикл по числам в группах
                {
                    N[i][k] = j;
                    //Console.Write(N[i][k] + " ");                 // Вывод в консоль для проверки.
                    k++;
                }
                pow = pow * 2;
            }
            return N;

        }


        /// <summary>
        /// Метод архивации
        /// </summary>
        /// <param name="FileName"></param>
        static void ZIP(string FileName)
        {

            string compressed = FileName + ".zip";
            using (FileStream ss = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                using (FileStream ts = File.Create(compressed))   // поток для записи сжатого файла
                {
                    // поток архивации
                    using (GZipStream cs = new GZipStream(ts, CompressionMode.Compress))
                    {
                        ss.CopyTo(cs);                            // копируем байты из одного потока в другой
                        Console.WriteLine("Сжатие файла {0} завершено. Было: {1}  стало: {2}.",
                                          FileName,
                                          ss.Length,
                                          ts.Length);
                    }
                }
            }

        }


        /// <summary>
        /// Основная логика
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string FileName = EnterFile();                    // получение имени файла
            int n = ReadN(FileName);                          // Читаем из файла число N
            int m = Chek(n);                                  // Метод возвращает число групп с неделимыми числами

            Console.WriteLine("1 - Показать число групп\n" +
                             " 2 - Записать в файл все группы\n" +
                             "для выхода любую другую клавишу ");

            switch (char.ToLower(Console.ReadKey(true).KeyChar))
            {
                case '1':
                    Mode1(n, m);                                       // РЕжим работы 1: Вывести количество групп
                    break;
                case '2':                                              // Режим работы 2: записать все в файл
                    Mode2(n, m, FileName);
                    break;
            }
            Console.ReadKey();
        }
    }
}



//1.Программа считыват из файла (путь к которому можно указать) некоторое
//N <= 1.000.000.000,
//для которого нужно подсчитать количество групп

//            В программе два режима работы:

//1.в консоли показывается только количество групп, т е значение M

//2. программа получает заполненные группы и записывает их в файл используя один из
//   вариантов работы с файлами
//После выполнения программа предлагает заархивировать данные и если пользователь    соглашается - делает это.

//3. После выполения пунктов 2.1 или 2.2 в консоли отображается время, за которое был выдан результат в секундах и миллисекундах