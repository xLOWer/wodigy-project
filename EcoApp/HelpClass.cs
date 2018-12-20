// ссылки на другие namespase
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace(пространство имён) в котором сейчас работаем
namespace EcoApp
{
    // класс
    // МодификаторДоступа   class  ИмяКласса   { }
    class HelpClass
    {

/* ОСНОВНЫЕ ТИПЫ ДАННЫХ */

// https://docs.microsoft.com/ru-ru/dotnet/csharp/tour-of-csharp/types-and-variables
// https://metanit.com/sharp/tutorial/2.1.php

        private int _int = 0; // целые числа
        private double _double = .0001; // дробные, десятичные числа
        private decimal _decimal = 128; // тоже дробные, десятичные числа, но другая структура данных
        private float _float = 0; // тоже дробные, десятичные числа, но с фиксированной запятой
        private string _string = "строка"; // строка
        private bool _bool = false || true; // логический тип, true или false
        private byte _byte = 255; // байт, от -128 до +128 если signed(знаковый) или от 0 до 255 если unsigned(беззнаковый)
        private char _char = 'a'; // символ Unicode


/* ПЕРЕМЕННЫЕ */


        private int i; // Объявление переменной i
        private float s = new float(); // объявление переменой и инициализация
        private double d = 0; // Объявление переменной d с инициализацией и присваиванием значения
        // ТипПеременной  ИмяПеременной = new ТипПеременной();
        // Тип1  Имя1 = new Тип1() { Свойство1 = ПрисваиваниеЗначения1,  Свойство2 = ПрисваиваниеЗначения2,}; // инициализация сложных структур со свойствами внутри
        // Тип2 Имя2;
        // Имя2 = new Тип2(): // вариант инициализации


/* СВОЙСТВА */

            
        private  string name1; // поле класса
        private string Name1 // свойство для обращения класса
        {
            get { return name1; } // GET ВЫДАЁТ значение поля name
            set { name1 = value; } //SET ЗАДАЁТ значение поля name
        }

        private string Name2 { get; set; } // можно использовать просто своёства без полей
        // ТипСвойства  ИмяСвойства { get; set; }
               
/* ФУНКЦИИ */

            
        private void func1() // объявление обычной функции типа void без параметров
        {
            // функция типа void НЕ ДОЛЖНА ничего ВОЗВРАЩАТЬ, НО МОЖЕТ
            // например нам надо проверить чтото перед тем, как продолжить вычисления
            if (name1 == "") return; // мы провеили пуста ли строка и вышли из функции ничего не вернув
        }

        private int func2(int argument) // объявление функции типа int с одним аргументом
        {
            // такая функция ОБЯЗАТЕЛЬНО ДОЛЖНА ВЕРНУТЬ объект ТАКОГО-ЖЕ ТИПА как она сама
            return 0; // 0 число
            return argument;
            // тут ругается на недостижимый код
            //потомучто когда мы чтото возвращаем то дальше ничего не выполняется и из функции выходим
        }


        private int func2(int argument1, string argument2) // объявление перегрузки функции
        {
            // перегрузка функции это такая функция с таким-же названием как уже имеющаяся
            // но с другим количественным или качественным составом аргументов
            // она так-же должна что-то вернуть в результате работы
            var variable = argument1 + int.Parse(argument2);
            return variable;
        }


        private int func2(int argument1, int argument2) // объявление с качественно другим составом аргументов
        {
            // демонстрация качественного изменения аргументов
            // в первом случае у нас есть один аргумент типа int
            // во втором случае два аргумента int и string
            // в третьем случае два аргумента int и int
            var variable = argument1 - argument2;
            return variable;
        }

        // Модификатор   ТипФункции   ИмяФункции (ТипАргумента1 Имя1, ...., ТипАргументаN ИмяN) // в конце точки с запятой не надо
        //{
        // если тип не void то обязательно:
        //      return ОбъектТакогоЖеТипаКакФункция;
        //}

/* КЛАССЫ */

        class ClassName   // объявляем класс
        {
            public string Property1 { get; set; } // свойство 1
            public string Property2 { get; set; } // свойство 2

            // конструктор класса
            public ClassName(string Property1, string Property2)
            {
                // свойству класса, из контекста через this, задаём значение пришедшее из аргумента конструктора
                this            .Property1       = Property1; 
              //^                ^                 ^
              //this=ClassName | свойство класса | параметр из аргументов
                this.Property2 = Property2;
            }
            public ClassName() { } // конструктор по-умолчанию
        }

        private void func(string a, string b)
        {
            // вид определения экземпляра класса 1: через констркутор по-умолчанию
            ClassName         ClassName_Name1 = new                  ClassName();
          // ^                ^                 ^                    ^
          // тип=имя класса | имя экземпляра1 | ключевое слово new | вызов конструктора (в данном случае по-умолчанию)
                      
            // вид определения экземпляра класса 2: через перегруженный констркутор
            ClassName         ClassName_Name2 = new                  ClassName(a, b);
          // ^                ^                 ^                    ^
          // тип=имя класса | имя экземпляра2 | ключевое слово new | вызов 'нашего' конструктора, с параметрами
                      
            // вид определения экземпляра класса 3: через явное задание свойств
            ClassName         ClassName_Name3 = new                  ClassName() { Property1 = a, Property2 = b};
          // ^                ^                 ^                    ^
          // тип=имя класса | имя экземпляра3 | ключевое слово new | конструктор | внутри определяем свойства

        }

/* КОНСТРУКТОРЫ */


        private HelpClass() // конструктор класса
        {
            // он всегда без типа, но как функция, которая что-то делает
        }

        private HelpClass(int argument)
        {
            // конструкторы точно так-же можно перегружать как и функция
            // от функций они отличаются только лишь отсутствием возвращаемого типа
            // и конструктор НЕ МОЖЕТ ВЕРНУТЬ какого либо ЗНАЧЕНИЯ и использывать return для прерывания работы
        }

        //Модификатор  ИмяКакУКласса  ( [АРГУМЕНТЫ] ) { }


/* ИНИЦИАЛИЗАЦИЯ ОБЪЕКТА */


// https://msdn.microsoft.com/ru-ru/library/w7wd1177.aspx
// https://metanit.com/sharp/tutorial/3.1.php
// https://professorweb.ru/my/csharp/charp_theory/level3/3_4.php
        // инициализация - это процесс задания начального значения объекта

        private HelpClass _HelpClass = new HelpClass(); // инициализация экземпляра класса
        private HelpClass _HelpClass1 = new HelpClass(new int()); // инициализация экземпляра класса с инициализацией анонимного экземпляра целочисленного типа    
        private decimal _decimal1 = new decimal(33.33); // инициализация переменной с явной задачей значения

/* УСЛОВИЯ */

        private void func()
        {
            // для обычных типов
            int i = 0, a;

            if (i > 0) a = 1; //    если i больше 0
            if (i < 0) a = -1; //   если i меньше 0
            if (i == 0) a = 0; //   если i равно 0 *пройдёт проверку это условие
            
            int b = 0, c = 0, d;

            if (b != c && b > c) d = b + c; //  если b не равно c И b больше c
            if (b >= c || b <= c) d = 0; //     если b больше или равно с ИЛИ b меньше или равно c *пройдёт это условие

            // для логических типов
            bool    IsHuman             = true, // является человеком
                    IsCanSpeakingRussian= true, // умеет говорить по-русски
                    IsCanPlayBalalayka  = true; // умеет играть на балалайке
            string  WhoIs               = "";

            if (IsHuman && IsCanSpeakingRussian && IsCanPlayBalalayka)      WhoIs = "Russian";
            // условие чиатется как: это человек, умеет говорить по-русски и умеет играть на балалайке

            if (IsHuman && !IsCanSpeakingRussian && !IsCanPlayBalalayka)    WhoIs = "American";
            if (IsHuman && IsCanSpeakingRussian && !IsCanPlayBalalayka)     WhoIs = "Ukrain";
            if (IsHuman && !IsCanSpeakingRussian && IsCanPlayBalalayka)     WhoIs = "Belarusian";
            if (!IsHuman && !IsCanSpeakingRussian && IsCanPlayBalalayka)    WhoIs = "Russian Bear";
            if (!IsHuman && !IsCanSpeakingRussian && !IsCanPlayBalalayka)   WhoIs = "Alien From Alpha Centauri";

            /*
             ЛОГИЧЕСКИЕ операторы (не путать с бинарными)
             &&     И
             ||     ИЛИ
             >      больше
             <      меньше
             ==     равно
             !      НЕ       выражение в if (!true == false) значит true
             !=     НЕ равно
             >=     больше или равно
             <=     меньше или равно             
             */
        }

    }
}
