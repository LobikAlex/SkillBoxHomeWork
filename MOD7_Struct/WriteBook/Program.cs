﻿using System;

namespace WriteBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Worker W = new Worker();
            W.id = 1;
            W.Name = "LobikAlex";





            Console.WriteLine(W.id);
           
              


            
            
        }
    }
}



//Задача
//Цели домашнего задания
//Научиться:

//применять модификаторы доступа;
//создавать собственные типы данных.


//Что нужно сделать
//Улучшите программу, которую разработали в модуле 6. Создайте структуру «Сотрудник» со следующими полями:

//ID
//Дата и время добавления записи
//Ф.И.О.
//Возраст
//Рост
//Дата рождения
//Место рождения


//Для записей реализуйте следующие функции:

//Просмотр записи.Функция должна содержать параметр ID записи, которую необходимо вывести на экран.
//Создание записи.
//Удаление записи.
//Редактирование записи.
//Загрузка записей в выбранном диапазоне дат.
//Сортировка по возрастанию и убыванию даты.


//После всех изменений записей создайте метод перезаписи изменённых данных в файл в таком виде:

//1#20.12.2021 00:12#Иванов Иван Иванович#25#176#05.05.1992#город Москва

//2#15.12.2021 03:12#Алексеев Алексей Иванович#24#176#05.11.1980#город Томск

//…



//Советы и рекомендации
//Обратите внимание, что в строке есть символ # — разделитель. Символа # не должно быть при чтении
//(разбить строку на массив поможет разделение строк с помощью метода String.Split).
//Создайте методы для работы с записями.
//Файл может быть с данными изначально. Для примера скопируйте данные, продемонстрированные выше.


//Что оценивается
//Создан ежедневник, в котором могут храниться записи.
//Одно из полей записи ― дата создания.
//Все записи сохраняются на диске.
//Все записи загружаются с диска.
//С диска загружаются записи в выбранном диапазоне дат.
//Записи можно создавать, редактировать и удалять.
//Записи сортируются по выбранному полю.