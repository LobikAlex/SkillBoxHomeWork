using System;

namespace MOD5_7_Убираем_кратные_символы
{
    class Program
    {

        /// <summary>
        /// Метод, удаляющий в слове дубликаты букв
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        static string nonDuplicates(string str)
        {
            str = str.ToLower();                  // преобразуем строку к нижнему регистру
            string result = "" + str[0];          // Результирующей строке присваиваем первый символ
            for (int i = 1; i < str.Length; i++)  //Идем циклом по всем символам
            {
                if (str[i] != str[i-1])           // если следующий символ отличается от предыдущего, то 
                {
                    result += str[i];             // добавляем его в новую сторку
                }                   
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст с дубликатами:");
            string str = Console.ReadLine();

            Console.WriteLine(nonDuplicates(str));
            Console.ReadKey();
        }
    }
}
// Задание 3. Создать метод, принимающий текст. 
// Результатом работы метода должен быть новый текст, в котором
// удалены все кратные рядом стоящие символы, оставив по одному 
// Пример: ПППОООГГГООООДДДААА >>> ПОГОДА
// Пример: Ххххоооорррооошшшиий деееннннь >>> хороший день