using System;

namespace EcoApp
{
    // класс операции
    public class Operation
    {
        // конструктор класса операции
        public Operation()
        {

        }
        public Guid Id { get; set; } // свойство, id операции
        public string Name { get; set; } // свойство, имя операции
        public decimal Value { get; set; } // значение операции
        public OperationType? Type { get; set; } // тип операции
    }
}