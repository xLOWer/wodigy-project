namespace EcoApp
{
    // класс операции
    public class Operation
    {
        // конструктор класса операции
        public Operation()
        {

        }

        public string Name { get; set; } // свойство, имя операции
        public decimal Value { get; set; } // значение операции
        public OperationType? Type { get; set; } // тип операции
    }
}