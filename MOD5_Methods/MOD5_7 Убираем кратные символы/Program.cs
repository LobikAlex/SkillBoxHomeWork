using System;

namespace MOD5_7_Убираем_кратные_символы
{
    class Program
    {
        static string nonDuplicates(string str)
        {
            string result = "" + str[0];
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] != str[i-1])
                {
                    result += str[i];
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