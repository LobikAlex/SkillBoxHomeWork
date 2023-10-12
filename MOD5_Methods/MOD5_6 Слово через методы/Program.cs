using System;

namespace MOD5_6_Слово_через_методы
{
    class Program
    {   
        
        // МЕтод возвращает самое короткое слово в тексте
        static string S(string str)
        {
 // Меняем все пробелы и точки на запятые           
            str = str.Replace(' ', ',');
            str = str.Replace('.', ',');

// Разделяем строку на отдельные слова
            string[] SplitArray = str.Split(',', StringSplitOptions.RemoveEmptyEntries);      
            string S = SplitArray[0];                         // Берем первый элемент
            string Sm = S;                       
            int min = S.Length;                        // Вычмисляем его длину и устанавливаем ее как минимальную

            
            for (int i = 0; i < SplitArray.Length; i++)     // Идем по всему массиву строк
            {
                S = SplitArray[i];
                if (S.Length < min)                         // ищем элемент с наименьшей длиной
                {
                    Sm = S;                                 // Этото элемент и есть искомая строка
                }
                
            }
            return Sm;
        }        

        // Метод возвращает самые длинные слова
        static string MAX(string str)
        {

            str = str.Replace(' ', ',');
            str = str.Replace('.', ',');
            string[] SplitArray = str.Split(',', StringSplitOptions.RemoveEmptyEntries);
            string S = SplitArray[0];            
            string Sm = "";
            int max = S.Length;

// Тут вычисляем числовую длину самой длинной подстроки    max
            for (int i = 0; i < SplitArray.Length; i++)
            {
                S = SplitArray[i];
                if (S.Length > max)
                {
                    max = S.Length;
                }
            }

            // а теперь все подстроки с этой длиной собираем в одну строку Sm
            for (int i = 0; i < SplitArray.Length; i++)
            {
                S = SplitArray[i];
                if (S.Length == max)
                 {
                  Sm += S + ", ";
                 }
            }
            return Sm;
        }      


        // Тело программы
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько слов в одну строку");
            string str = Console.ReadLine();

            string result = S(str);
            Console.WriteLine("Минимальное слово: " + result);

            string resultmax = MAX(str);
            Console.WriteLine("Самые длинные слова: " + resultmax);
        }
    }
}
// Задание 2.
// 1. Создать метод, принимающий  текст и возвращающий слово, содержащее минимальное количество букв
// 2.* Создать метод, принимающий  текст и возвращающий слово(слова) с максимальным количеством букв 
// Примечание: слова в тексте могут быть разделены символами (пробелом, точкой, запятой) 
// Пример: Текст: "A ББ ВВВ. ГГГГ, ДДДД  ДД ЕЕ ЖЖ ЗЗЗ"
// 1. Ответ: А
// 2. ГГГГ, ДДДД
