using System;
using System.Text;
using System.IO;

namespace Записная_книжка
{
    class Program  // Справочник Сотрудники
    {

        // Метод валидации чисел 1 и 2
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


        // Метод чтения данных
        static void ReadFile(string name)
        {
            using (StreamReader sr = new StreamReader(name, Encoding.Unicode))
            {
                string line;
                Console.WriteLine($"{"ID",4}\t{" Дата: ", 10}\t{" ФИО", 30}\t {"Возраст", 9}\t{"Рост", 6}\t{"Дата рождения", 20}\t{"Место рождения",20}\t");

                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('#');
                    Console.WriteLine($"{data[0], 2}\t {data[1], 8}\t {data[2], 30}\t {data[3], 7}\t {data[4], 3} \t{data[5],20}\t {data[6],20}");
                }
            }
        }

        // Метод записи данных
                static void WriteFile(string name)
        {
            using (StreamWriter sw = new StreamWriter(name, true, Encoding.Unicode))
            {
                char key = 'д';

                do
                {
                    string note = string.Empty;
                    Console.Write("\nВведите ID записи: ");
                    note += $"{Console.ReadLine()}#";

                    DateTime now = DateTime.Now;
                    Console.WriteLine($"Время заметки {now}");
                    note += $"{now}#";

                    Console.Write("ФИО: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Возраст: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Рост: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Дата рождения: ");
                    note += $"{Console.ReadLine()}#";

                    Console.Write("Место рождения: ");
                    note += $"{Console.ReadLine()}#";

                    sw.WriteLine(note);
                    Console.WriteLine("Продожить н/д"); key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'д');
                Console.WriteLine("Записи добавлены");
            }

        }


        static void Main(string[] args)
        {
           
            Console.WriteLine("Записная книжка. Введите имя файла:");
            string name = Console.ReadLine();


            if (File.Exists(@name))                               // Проверяем существует ли файл
            {
                byte n = InputByte();                            // если существует, проверяем 1 или 2

                switch (n)
                {
                    case 1: ReadFile(@name); break;             // 1 прочитать
                    case 2: WriteFile(@name); break;            // 2 записать
                }
            }
            else
            {
                Console.WriteLine("Файла не существует. Создадим его.");
                WriteFile(@name);
            }


            if (File.Exists(@name))                               //Проверяем создание файла
            {
               Console.WriteLine($"Файл {name} успешно создан");
            }
            else
            {
               Console.WriteLine("Файл НЕ создан");
            }

            Console.WriteLine("Для выхода нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}


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