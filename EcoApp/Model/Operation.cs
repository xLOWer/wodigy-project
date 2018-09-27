using System;

namespace EcoApp.Model
{
    public class Operation
    {
        public Operation()
        {
            Id = Guid.NewGuid();
            Name = "";
            Type = 0;
            Value = 0;
        }
        public Guid Id { get; set; } // идентификатор
        public string Name { get; set; } // наименование
        public OperationType Type { get; set; } // тип операции
        public double Value { get; set; } // значение

        public IObservable<Operation> Childs { get; set; } // все наследники данной сущности
        public Operation Parent { get; set; } // родитель данной сущности
    }
}
