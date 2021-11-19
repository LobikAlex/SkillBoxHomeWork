using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteBook
{
    struct Worker
    {
        public byte id; //     { get; private set; }   // ID можем читать, но не можем изменить.  Private активировать после присвоения
        public DateTime data;
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public byte age;
        public string town;



        /// <summary>
        /// Метод печатающий всю структуру
        /// </summary>
        /// <returns></returns>
        public string PrintWorker()
        {
            return $"ID: {id}, \t Date: {data}, \tName: {name}, \tAge: {age}, \t TOWN: {town}";
        }



        /// <summary>
        /// КОнстурктор структуры
        /// </summary>
        /// <param name="id"></param>
        /// <param name="data"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="town"></param>
        public Worker(byte id, DateTime data, string name, byte age, string town) //    Описаны все переменные   
        {
            this.id = id;
            this.data = data;
            this.name = name;
            this.age = age;
            this.town = town;        
        }

        public Worker(byte id, string name, byte age, string town):         // без даты
            this(id, new DateTime(), name, age, town)
        {            
        }

        public Worker(byte id, string name, byte age) :                //  Без города
          this(id, new DateTime(), name, age, string.Empty)
        {
        }

        public Worker(byte id, string name) :                          // без возраста
             this(id, new DateTime(), name, 0, string.Empty)
        {
        }

        public Worker(byte id) :                                       // Без имени
            this(id, new DateTime(), string.Empty, 0, string.Empty)
        {
        }



    }
}
