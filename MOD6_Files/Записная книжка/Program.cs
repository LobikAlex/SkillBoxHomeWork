using System;
using System.Text;
using System.IO;

namespace Записная_книжка
{
    class Program  /// Справочник "Сотрудники"
    {

        /// <summary>
        /// Метод валидации чисел 1 и 2
        /// </summary>
        /// <returns></returns>        
        static byte InputByte()
        {
            Console.WriteLine("1 - Read data\n 2 - Write data");

            byte n;
            while (!byte.TryParse(Console.ReadLine(), out n) | n > 2)
            {
                Console.WriteLine("Ошибка ввода!\n1 - Read data\n2 - Write data");
            }
            return n;
        }

        /// <summary>
        /// Вывод в консоль формы ввода данных
        /// </summary>
        /// <param name="Head"></param>
        /// <param name="i"></param>
        static void MetodWrite(string[] Head, int i)
        {

            Console.Write($"Введите {Head[i]}: ");

        }


        /// <summary>
        /// Метод чтения строки из файла
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Head"></param>
        static void ReadFile(string name)
        {
            using (StreamReader sr = new StreamReader(name, Encoding.Unicode))
            {
                string line;

                while ((line = sr.ReadLine()) != null)                      // читаем строку из файла
                {
                    PrintData(line);                                           // отправляем ее на разбивку и печать
                }


            }
        }


        /// <summary>
        ///  МЕтод Интерфейса записи данных в файл
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Head"></param>
        static void WriteFile(string name, string[] Head)
        {
            if (!File.Exists(@name))                                 // Проверка сущестоввания файла
            {
                Console.WriteLine("Файла не существует. Создадим его.");
            }

            {
                char key = 'д';
                do
                {
                    StreamW(name, Head);                             // Вызываем основной метод записи в потоке

                    Console.WriteLine("Продожить заполнение? н/д");
                    key = Console.ReadKey(true).KeyChar;
                }
                while (char.ToLower(key) == 'д');

                Console.WriteLine("Записи добавлены");

                if (File.Exists(@name))                               //Проверяем создание файла
                {
                    Console.WriteLine($"Файл {name} успешно создан");
                }
                else
                {
                    Console.WriteLine("Файл НЕ создан");
                }
            }
        }


        /// <summary>
        /// Основной метод записи в потоке
        /// </summary>
        /// <param name="name"></param>
        /// <param name="Head"></param>
        static void StreamW(string name, string[] Head)
        {
            using (StreamWriter sw = new StreamWriter(name, true, Encoding.Unicode))
            {
                string note = string.Empty;
                DateTime now = DateTime.Now;
                for (int i = 0; i < Head.Length; i++)
                {
                    if (i == 1)
                    {
                        note += $"{now}#"; continue;
                    }
                    MetodWrite(Head, i);
                    note += $"{Console.ReadLine()}#";
                }
                sw.WriteLine(note);
            }
        }



        /// <summary>
        /// Метод вывода заголовков в консоль 
        /// </summary>
        /// <param name="Head"></param>
        static void PrintHead(string[] Head)
        {
            Console.WriteLine($"{Head[0],4}\t{Head[1],19}\t{Head[2],20}\t {Head[3],9}\t{ Head[4],6}\t{Head[5],10}\t{Head[6],10}\t");      // Выводим заголовки
        }



        /// <summary>
        /// Метод вывода данных в консоль 
        /// </summary>
        /// <param name="args"></param>
        static void PrintData(string line)
        {
            string[] data = line.Split('#');                                // бьем строки на отдельные слова 
            Console.WriteLine($"{data[0],2}\t {data[1],8}\t {data[2],20}\t {data[3],7}\t {data[4],3} \t{data[5],10}\t {data[6],10}");  // и выводим их

        }



        /// <summary>
        /// Основная логика
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Записная книжка. Введите имя файла:");
            string name = Console.ReadLine();

            // Создаем поля для ввода в строковый массив. Они же будут заголовками таблицы.
            string[] Head = new string[7];
            Head[0] = "ID";
            Head[1] = "Дата добавления";
            Head[2] = "ФИО";
            Head[3] = "Возраст";
            Head[4] = "Рост";
            Head[5] = "Дата рождения";
            Head[6] = "Место рождения";


            if (File.Exists(@name))                               // Проверяем существует ли файл
            {
                byte n = InputByte();                            // если существует, спрашиваем: 1 или 2?

                switch (n)
                {
                    case 1:                                      // если 1 то 
                        PrintHead(Head);                         // печатаем заголовки
                        ReadFile(@name);                         // Читаем из файла данные и печатем их
                        break;
                    case 2: WriteFile(@name, Head); break;       // 2 вызываем метод записи 
                }
            }
            else
            {
                WriteFile(@name, Head);                                      // Создаем файл и записываем в него
            }

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}


//  Основное Задание
//Создайте справочник «Сотрудники».

//Разработайте для предполагаемой компании программу, которая будет добавлять записи новых сотрудников в файл. Файл должен содержать следующие данные:

//ID
//Дату и время добавления записи
//Ф. И. О.
//Возраст
//Рост
//Дату рождения
//Место рождения
//Для этого необходим ввод данных с клавиатуры. После ввода данных:

//если файла не существует, его необходимо создать;
//если файл существует, то необходимо записать данные сотрудника в конец файла. 
//При запуске программы должен быть выбор:

//введём 1 — вывести данные на экран;
//введём 2 — заполнить данные и добавить новую запись в конец файла.


//Файл должен иметь следующую структуру:

//1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва
//2#15.12.2021 03:12#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск
//…


//Советы и рекомендации
//Обратите внимание, что в строке есть символ # — разделитель в строке. При чтении файла необходимо убрать символ #. Разбить строку на массив элементов поможет разделение строк с помощью метода String.Split.
//Разбейте программу на методы (чтение, запись).
//Новую запись внесите в конец файла.
//Проверьте, создан файл или нет.


//Что оценивается
//Структура файла после добавления сотрудника идентична.
//Каждый метод выполняет одну задачу.
//Запись корректно выводится в консоль.
//Файл корректно закрывается после записи и чтения.