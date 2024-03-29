﻿using System;

namespace MOD5_1
{
    class Program
    {
        static string[] Split(String str)
        {
            string[] SplitArray = str.Split(' ');
            return SplitArray;
        }

        static void Print(string[] www)
        {
            foreach (var i in www)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {

            string str = "Я помню чудное мгновенье!";

            String[] SplitArray = Split(str);
            Print(SplitArray);

            Console.ReadKey();
        }
    }
}

//Задание 1. Метод разделения строки на слова


//Что нужно сделать
//Пользователь вводит в консольном приложении длинное предложение. Каждое слово в этом предложении отделено одним пробелом.
//Необходимо создать метод, который в качестве входного параметра принимает строковую переменную,
//а в качестве возвращаемого значения — массив слов. После вызова данного метода программа вызывает второй метод,
//который выводит каждое слово в отдельной строке.   



//Советы и рекомендации
//Для реализации данной программы можно написать алгоритм разделения на слова самостоятельно, используя цикл.
//Также можете использовать метод string.Split(‘ ’); Прочитайте об этом методе подробнее на странице документации Microsoft.
//Для названия методов используйте CamelCase, когда каждое следующее слово начинается с заглавной буквы.
//Например, метод с именем GetPositiveRandomInt возвращает положительное целое случайное число. По такому же принципу следует называть и свои методы. 


//Что оценивается
//В программе, помимо основного метода main, присутствует два других метода, которые вызываются в теле метода main. 
//Названием методов соответствуют тому, что они делают (разделяют или выводят данные).